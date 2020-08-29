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
    public class GradoviService : IGradoviService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public GradoviService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Grad> Get(GradoviSearchRequest request)
        {
            var query = _context.Gradovi.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => (x.Naziv).Contains(request.Naziv));
            }
            if (request?.DrzavaId != 0)
            {
                query = query.Where(x => x.DrzavaId == request.DrzavaId);

            }
            query = query.Include(x => x.Drzava);


            var list = query.ToList();

            return _mapper.Map<List<Model.Grad>>(list);
        }

        public Model.Grad GetById(int id)
        {
            var entity = _context.Gradovi.Where(x => x.GradId == id)
                .Include(x => x.Drzava)
                .FirstOrDefault();

            return _mapper.Map<Model.Grad>(entity);
        }

        public Model.Grad Insert(GradoviInsertRequest request)
        {
            var entity = _mapper.Map<Database.Grad>(request);



            _context.Gradovi.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Grad>(entity);
        }

        public Model.Grad Update(int id, GradoviInsertRequest request)
        {
            var entity = _context.Gradovi.Find(id);
            _context.Gradovi.Attach(entity);
            _context.Gradovi.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Grad>(entity);
        }


    }
}
