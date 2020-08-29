using AutoMapper;
using BookIT.Model.Requests;
using BookIT.WebAPI.Database;
using BookIT.WebAPI.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public class RezervacijeService : IRezervacijeService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public RezervacijeService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Rezervacija> Get(RezervacijeSearchRequest request)
        {
            var query = _context.Rezervacije.AsQueryable();
            if (BasicAuthenticationHandler.user.Uloga.Naziv == "Klijent")
                query = query.Where(x => x.KlijentId == BasicAuthenticationHandler.user.KorisnikId);

            if (BasicAuthenticationHandler.user.Uloga.Naziv == "Vlasnik smještaja")
                query = query.Where(x => x.Smjestaj.VlasnikSmjestajaId == BasicAuthenticationHandler.user.KorisnikId);

            query = query.OrderByDescending(x => x.DatumRezervacije);

            if (request?.SmjestajId != 0)
            {
                query = query.Where(x => (x.SmjestajId == request.SmjestajId));
            }
            query = query.Include(x => x.Smjestaj)
                .Include(x => x.SobaRezervacija);



            var list = query.ToList();

            return _mapper.Map<List<Model.Rezervacija>>(list);
        }

        public Model.Rezervacija GetById(int id)
        {
            var entity = _context.Rezervacije.Where(x => x.RezervacijaId == id)
                .Include(x => x.Klijent.Korisnik.Grad.Drzava)
                .Include(x => x.Smjestaj.VlasnikSmjestaja.Korisnik.Grad.Drzava)
                .FirstOrDefault();


            return _mapper.Map<Model.Rezervacija>(entity);
        }

        public Model.Rezervacija Insert(RezervacijeInsertRequest request)
        {

            var entity = _mapper.Map<Database.Rezervacija>(request);
            entity.KlijentId = Security.BasicAuthenticationHandler.user.KorisnikId;
            entity.Status = Rezervacija.eStanje.CekanjePotvrde;


            _context.Rezervacije.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacija>(entity);
        }
        public Model.Rezervacija Update(int id, RezervacijeUpdateRequest request)
        {
            var entity = _context.Rezervacije.Include(x=>x.Smjestaj).Where(x=>x.RezervacijaId == id).FirstOrDefault();
            if (entity.Status == Rezervacija.eStanje.CekanjeUplate &&
                request.Status == Model.Rezervacija.eStanje.Finalizirana)
            {
                double Cijena = GetCijenaRezervacije(entity);
                Faktura faktura = new Faktura
                {
                    DatumFakture = DateTime.Now,
                    Iznos = Cijena,
                    RezervacijaId = entity.RezervacijaId
                };
                _context.Fakture.Add(faktura);
            }

            _context.Rezervacije.Attach(entity);
            _context.Rezervacije.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacija>(entity);
        }

        private double GetCijenaRezervacije(Rezervacija rezervacija)
        {
            bool IsApartman = false;
            switch (rezervacija.Smjestaj.TipSmjestaja)
            {
                case TipSmjestaja.Apartman:
                case TipSmjestaja.Vila:
                case TipSmjestaja.Kuca:
                    IsApartman = true;
                    break;
                default:
                    IsApartman = false;
                    break;

            }
            // Get sve sobe koje su odabrane u rezervaciji
            var resultSobeRezervacije = _context.SobeRezervacije.Where(x => x.RezervacijaId == rezervacija.RezervacijaId).ToList();

            // Get sve dodatne usluge koje su odabrane u rezervaciji
            var resultDodatneUslugeRezervacije = _context.DodatneUslugeRezervacije.Where(x => x.RezervacijaId == rezervacija.RezervacijaId).ToList();

            double Cijena = 0;
            // sum the prices of selected rooms and facilities to get the final price

            if (IsApartman)
            {
                Cijena += rezervacija.Smjestaj.Cijena.Value;
            }
            else
            {
                foreach (SobaRezervacija item in resultSobeRezervacije)
                {
                    Cijena += item.Cijena;
                }
            }

            foreach (DodatnaUslugaRezervacija item in resultDodatneUslugeRezervacije)
            {
                Cijena += item.Cijena;
            }

            double NumOfDays = Math.Ceiling((rezervacija.CheckOutDate - rezervacija.CheckInDate).TotalDays);
            Cijena *= NumOfDays;

            return Cijena;
        }


    }
}
