using AutoMapper;
using BookIT.Model.Requests;
using BookIT.WebAPI.Database;
using BookIT.WebAPI.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public class SobeSlikeService:ISobeSlikeService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public SobeSlikeService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.SobaSlika> Get(SobeSlikeSearchRequest request)
        {
            var query = _context.SobeSlike.AsQueryable();
            if (request.SobaId != 0)
            {
                query = query.Where(x => (x.SobaId == request.SobaId));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.SobaSlika>>(list);
        }

        public Model.SobaSlika GetById(int id)
        {
            var entity = _context.SobeSlike.Where(x => x.SobaSlikaId == id)
                .FirstOrDefault();

            return _mapper.Map<Model.SobaSlika>(entity);
        }

        public Model.SobaSlika Insert(SobeSlikeInsertRequest request)
        {
            var entity = _mapper.Map<Database.SobaSlika>(request);

            _context.SobeSlike.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.SobaSlika>(entity);
        }

        public Model.SobaSlika Update(int id, SobeSlikeInsertRequest request)
        {
            var entity = _context.SobeSlike.Find(id);
            _context.SobeSlike.Attach(entity);
            _context.SobeSlike.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.SobaSlika>(entity);
        }

        public Model.SobaSlika GetSobeSlika(int Sobaid)
        {
            var entity = _context.SobeSlike.Where(x => x.SobaId == Sobaid).FirstOrDefault();

            if (entity == null)
                return null;
            return _mapper.Map<Model.SobaSlika>(entity);
        }

    }
}
