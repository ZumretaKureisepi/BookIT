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
    public class UlogeService : IUlogeService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public UlogeService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Uloga> Get()
        {
            var query = _context.Uloge.AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Uloga>>(list);
        }

        public Model.Uloga GetById(int id)
        {
            var entity = _context.Uloge.Where(x => x.UlogaId == id)
                .FirstOrDefault();

            return _mapper.Map<Model.Uloga>(entity);
        }

    }
}
