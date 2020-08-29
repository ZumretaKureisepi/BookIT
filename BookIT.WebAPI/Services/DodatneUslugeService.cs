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
    public class DodatneUslugeService:IDodatneUslugeService
    {

        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public DodatneUslugeService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.DodatnaUsluga> Get(DodatneUslugeSearchRequest request)
        {
            var query = _context.DodatneUsluge.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => (x.Naziv).Contains(request.Naziv));
            }


            var list = query.ToList();

            return _mapper.Map<List<Model.DodatnaUsluga>>(list);
        }

        public Model.DodatnaUsluga GetById(int id)
        {
            var entity = _context.DodatneUsluge.Where(x => x.DodatnaUslugaId == id)
                .FirstOrDefault();

            return _mapper.Map<Model.DodatnaUsluga>(entity);
        }

        public Model.DodatnaUsluga Insert(DodatneUslugeInsertRequest request)
        {
            var entity = _mapper.Map<Database.DodatnaUsluga>(request);



            _context.DodatneUsluge.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.DodatnaUsluga>(entity);
        }

        public Model.DodatnaUsluga Update(int id, DodatneUslugeInsertRequest request)
        {
            var entity = _context.DodatneUsluge.Find(id);
            _context.DodatneUsluge.Attach(entity);
            _context.DodatneUsluge.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.DodatnaUsluga>(entity);
        }



    }
}
