using AutoMapper;
using BookIT.Model.Requests;
using BookIT.WebAPI.Database;
using BookIT.WebAPI.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public class SmjestajiService : ISmjestajiService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public SmjestajiService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Smjestaj> Get(SmjestajiSearchRequest request)
        {
            var query = _context.Smjestaji.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => (x.Naziv).Contains(request.Naziv));
            }
            query = query.Where(x => x.VlasnikSmjestajaId == BasicAuthenticationHandler.user.KorisnikId);

            query = query.Include(x => x.Grad.Drzava);
            query = query.Include(x => x.VlasnikSmjestaja.Korisnik);


            var list = query.ToList();

            return _mapper.Map<List<Model.Smjestaj>>(list);
        }

        public Model.Smjestaj GetById(int id)
        {
            var entity = _context.Smjestaji.Where(x => x.SmjestajId == id)
                .Include(x => x.Grad.Drzava)
                .Include(x=> x.SmjestajTipDestinacije)
                .FirstOrDefault();

            return _mapper.Map<Model.Smjestaj>(entity);
        }

        public double GetFinalnaOcjena(int id)
        {
            double finalna_ocjena = _context.SmjestajiOcjene.Where(x => x.SmjestajId == id)
                .Average(x => (double?)x.FinalnaOcjena) ?? 0;

            return finalna_ocjena;

        }

        public Model.Smjestaj Insert(SmjestajiInsertRequest request)
        {
            var entity = _mapper.Map<Database.Smjestaj>(request);
            entity.VlasnikSmjestajaId = BasicAuthenticationHandler.user.KorisnikId;

            _context.Smjestaji.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Smjestaj>(entity);
        }

        public Model.Smjestaj Update(int id, SmjestajiInsertRequest request)
        {
            var entity = _context.Smjestaji.Find(id);

            var listTipSmjestaja = _context.SmjestajiTipDestinacija.Where(x => x.SmjestajId == id).ToList();
            foreach (var item in listTipSmjestaja)
            {
                _context.SmjestajiTipDestinacija.Remove(item);
            }

            _context.Smjestaji.Attach(entity);
            _context.Smjestaji.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Smjestaj>(entity);
        }
        public List<Model.Smjestaj> ClientGet(SmjestajiClientSearchRequest request)
        {
            var query = _context.Smjestaji.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Lokacija))
            {
                query = query.Where(x => (x.Grad.Naziv).Contains(request.Lokacija));
            }

            query = query.Include(x => x.Grad.Drzava);
            query = query.Include(x => x.VlasnikSmjestaja.Korisnik);


            var list = query.ToList();

            var full_list = _mapper.Map<List<Model.Smjestaj>>(list);
            var filtered_list = new List<Model.Smjestaj>();
            foreach (Model.Smjestaj smjestaj in full_list)
            {
                bool SkipSmjestaj = true;

                bool IsApartman;

                switch (smjestaj.TipSmjestaja)
                {
                    case Model.TipSmjestaja.Apartman:
                    case Model.TipSmjestaja.Vila:
                    case Model.TipSmjestaja.Kuca:
                        IsApartman = true;
                        break;
                    default:
                        IsApartman = false;
                        break;
                }


                int ukupnoOsoba = request.Odrasli + request.Djeca;

                if (!IsApartman)
                {
                    List<Soba> sobeHotela = _context.Sobe.Where(x => x.SmjestajId == smjestaj.SmjestajId).ToList();
                    int NumberOfAvailableBedsAcrossRooms = 0;
                    foreach (Soba soba in sobeHotela)
                    {
                        int kapacitetSobe = soba.BrojMalihKreveta + soba.BrojVelikihKreveta * 2;

                        bool overlappingReservations = _context.SobeRezervacije
                        .Where(x => x.SobaId == soba.SobaId) // gledamo samo rezervacije za trenutnu sobu koju provjeravamo

                       .Where(x =>
                        // prethodni datum prijave ulazi u interval nove rezervacije
                        (x.Rezervacija.CheckInDate.Date >= request.CheckInDate.Date &&
                                   x.Rezervacija.CheckInDate.Date < request.CheckOutDate.Date) ||
                       // prethodni datum odjave ulazi u interval nove rezervacije
                       (x.Rezervacija.CheckOutDate.Date > request.CheckInDate.Date &&
                                   x.Rezervacija.CheckOutDate.Date <= request.CheckOutDate.Date) ||
                       // novi datum prijave ulazi u interval stare rezervacije
                       (request.CheckInDate.Date >= x.Rezervacija.CheckInDate.Date &&
                                   request.CheckInDate.Date < x.Rezervacija.CheckOutDate.Date) ||
                       // novi datum odjave ulazi u interval stare rezervacije
                       (request.CheckOutDate.Date > x.Rezervacija.CheckInDate.Date &&
                                   request.CheckOutDate.Date <= x.Rezervacija.CheckOutDate.Date)
                        ).Any();


                        if (!overlappingReservations)
                        {
                            NumberOfAvailableBedsAcrossRooms += kapacitetSobe;
                            if (NumberOfAvailableBedsAcrossRooms >= ukupnoOsoba)
                            {
                                SkipSmjestaj = false;
                                break;
                            }
                        }

                    }
                }
                else
                {
                     bool overlappingReservations = _context.Rezervacije 
                        .Where(x => x.SmjestajId == smjestaj.SmjestajId) // gledamo rezervacije samo za trenutni smjestaj
                       .Where(x =>
                        // prethodni datum prijave ulazi u interval nove rezervacije
                        (x.CheckInDate.Date >= request.CheckInDate.Date &&
                                   x.CheckInDate.Date < request.CheckOutDate.Date) ||
                       // prethodni datum odjave ulazi u interval nove rezervacije
                       (x.CheckOutDate.Date > request.CheckInDate.Date &&
                                   x.CheckOutDate.Date <= request.CheckOutDate.Date) ||
                       // novi datum prijave ulazi u interval stare rezervacije
                       (request.CheckInDate.Date >= x.CheckInDate.Date &&
                                   request.CheckInDate.Date < x.CheckOutDate.Date) ||
                       // novi datum odjave ulazi u interval stare rezervacije
                       (request.CheckOutDate.Date > x.CheckInDate.Date &&
                                   request.CheckOutDate.Date <= x.CheckOutDate.Date)
                        ).Any();

                    if(!overlappingReservations)
                    {
                        SkipSmjestaj = false;
                    }
                }

                if (!SkipSmjestaj)
                    filtered_list.Add(smjestaj);


            }

            return filtered_list;
        }




    }
}
