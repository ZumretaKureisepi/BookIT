using AutoMapper;
using BookIT.Model.Requests;
using BookIT.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public class DodatneUslugeRezervacijeService : IDodatneUslugeRezervacijeService
    {

        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public DodatneUslugeRezervacijeService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.DodatnaUslugaRezervacija> Get(DodatneUslugeRezervacijeSearchRequest request)
        {
            var query = _context.DodatneUslugeRezervacije.AsQueryable();
            if (request.RezervacijaId != 0)
            {
                query = query.Where(x => x.RezervacijaId == request.RezervacijaId);
            }
            query = query.Include(x => x.DodatnaUsluga);

            var list = query.ToList();

            return _mapper.Map<List<Model.DodatnaUslugaRezervacija>>(list);
        }

        public Model.DodatnaUslugaRezervacija GetById(int id)
        {
            var entity = _context.DodatneUslugeRezervacije.Where(x => x.DodatnaUslugaRezervacijaId == id)
                .FirstOrDefault();


            return _mapper.Map<Model.DodatnaUslugaRezervacija>(entity);
        }

        public Model.DodatnaUslugaRezervacija Insert(DodatneUslugeRezervacijeInsertRequest request)
        {
            var entity = _mapper.Map<Database.DodatnaUslugaRezervacija>(request);
            Rezervacija rez = _context.Rezervacije.Find(request.RezervacijaId);

            if (request.SobaId == null)
                entity.Cijena = _context.DodatneUslugeSmjestaji
                    .Where(x => x.DodatnaUslugaId == request.DodatnaUslugaId && x.SmjestajId == rez.SmjestajId)
                    .FirstOrDefault().Cijena;
            else
                entity.Cijena = _context.DodatneUslugeSobe
                    .Where(x => x.DodatnaUslugaId == request.DodatnaUslugaId && x.SobaId == request.SobaId)
                    .FirstOrDefault().Cijena;

            _context.DodatneUslugeRezervacije.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.DodatnaUslugaRezervacija>(entity);
        }





    }
}
