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
    public class SmjestajiSlikeService : ISmjestajiSlikeService
    {


        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public SmjestajiSlikeService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.SmjestajSlika> Get(SmjestajiSlikeSearchRequest request)
        {
            var query = _context.SmjestajiSlike.AsQueryable();
            if (request.SmjestajId != 0)
            {
                query = query.Where(x => (x.SmjestajId == request.SmjestajId));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.SmjestajSlika>>(list);
        }

        public Model.SmjestajSlika GetById(int id)
        {
            var entity = _context.SmjestajiSlike.Where(x => x.SmjestajSlikaId == id)
                .FirstOrDefault();

            return _mapper.Map<Model.SmjestajSlika>(entity);
        }

        public Model.SmjestajSlika Insert(SmjestajiSlikeInsertRequest request)
        {
            var entity = _mapper.Map<Database.SmjestajSlika>(request);

            _context.SmjestajiSlike.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.SmjestajSlika>(entity);
        }

        public Model.SmjestajSlika Update(int id, SmjestajiSlikeInsertRequest request)
        {
            var entity = _context.SmjestajiSlike.Find(id);
            _context.SmjestajiSlike.Attach(entity);
            _context.SmjestajiSlike.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.SmjestajSlika>(entity);
        }

        public Model.SmjestajSlika GetSmjestajSlika(int SmjestajId)
        {
            var entity = _context.SmjestajiSlike.Where(x => x.SmjestajId == SmjestajId).FirstOrDefault();

            if (entity == null)
                return null;

            return _mapper.Map<Model.SmjestajSlika>(entity);

        }

    }
}
