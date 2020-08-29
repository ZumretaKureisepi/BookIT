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
    public class SobeRezervacijeService:ISobeRezervacijeService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public SobeRezervacijeService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.SobaRezervacija> Get(SobeRezervacijeSearchRequest request)
        {
            var query = _context.SobeRezervacije.AsQueryable();
            if (request?.RezervacijaId != 0)
            {
                query = query.Where(x => x.RezervacijaId == request.RezervacijaId);
            }
            query = query.Include(x => x.Soba);


            var list = query.ToList();

            return _mapper.Map<List<Model.SobaRezervacija>>(list);
        }

        public Model.SobaRezervacija GetById(int id)
        {
            var entity = _context.SobeRezervacije.Where(x => x.SobaRezervacijaId == id)
                .Include(x => x.Soba)
                .FirstOrDefault();

            return _mapper.Map<Model.SobaRezervacija>(entity);
        }

        public Model.SobaRezervacija Insert(SobeRezervacijeInsertRequest request)
        {
            var entity = _mapper.Map<Database.SobaRezervacija>(request);
            entity.Cijena = _context.Sobe.Where(x => x.SobaId == request.SobaId).FirstOrDefault().Cijena;


            _context.SobeRezervacije.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.SobaRezervacija>(entity);
        }

        


    }
}
