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
    public class FaktureService:IFaktureService
    {

        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public FaktureService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Faktura> Get(FaktureSearchRequest request)
        {
            var query = _context.Fakture.AsQueryable();
            if(BasicAuthenticationHandler.user.Uloga.Naziv=="Klijent")
            {
                query = query.Where(x => x.Rezervacija.KlijentId == BasicAuthenticationHandler.user.KorisnikId);
            }
            if(BasicAuthenticationHandler.user.Uloga.Naziv=="Vlasnik smještaja")
            {
                query = query.Where(x => x.Rezervacija.Smjestaj.VlasnikSmjestajaId == BasicAuthenticationHandler.user.KorisnikId);
            }
            if (!string.IsNullOrWhiteSpace(request?.ImeKlijenta))
            {
                query = query.Where(x => (x.Rezervacija.Klijent.Korisnik.Ime + " " + x.Rezervacija.Klijent.Korisnik.Prezime).Contains(request.ImeKlijenta));
            }
            if(request?.RezervacijaId != 0)
            {
                query = query.Where(x => x.RezervacijaId == request.RezervacijaId);
            }
            query = query.Include(x => x.Rezervacija.Klijent.Korisnik);

            var list = query.ToList();

            return _mapper.Map<List<Model.Faktura>>(list);
        }


        public Model.Faktura Insert(FaktureInsertRequest request)
        {

            var entity = _mapper.Map<Database.Faktura>(request);


            _context.Fakture.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Faktura>(entity);
        }

        public Model.Faktura GetById(int id)
        {
            var entity = _context.Fakture.Where(x => x.FakturaId == id)
                .Include(x => x.Rezervacija.Klijent.Korisnik.Grad.Drzava)
                .Include(x => x.Rezervacija.Smjestaj.VlasnikSmjestaja.Korisnik.Grad.Drzava)
                .FirstOrDefault();


            return _mapper.Map<Model.Faktura>(entity);
        }

    }
}
