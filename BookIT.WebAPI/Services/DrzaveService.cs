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
    public class DrzaveService:IDrzaveService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public DrzaveService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Drzava> Get()
        {
            var query = _context.Drzave.AsQueryable();
            var list = query.ToList();

            return _mapper.Map<List<Model.Drzava>>(list);
        }

        public Model.Drzava Insert(DrzaveInsertRequest request)
        {
            var entity = _mapper.Map<Database.Drzava>(request);
            _context.Drzave.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Drzava>(entity);
        }
        





    }
}
