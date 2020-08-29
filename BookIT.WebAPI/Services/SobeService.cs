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
    public class SobeService:ISobeService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public SobeService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Soba> Get(SobeSearchRequest request)
        {
            var query = _context.Sobe.AsQueryable();
            if (request.SmjestajId != 0)
            {
                //List<Soba> lista = _context.Sobe.Where(x => x.SmjestajId == request.SmjestajId).ToList();
                //return _mapper.Map<List<Model.Soba>>(lista);

                query = query.Where(x => x.SmjestajId == request.SmjestajId);

            }

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => (x.Naziv).Contains(request.Naziv));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Soba>>(list);
        }

        public Model.Soba GetById(int id)
        {
            var entity = _context.Sobe.Where(x => x.SobaId == id)
                //.Include(x => x.Drzava)
                .FirstOrDefault();

            return _mapper.Map<Model.Soba>(entity);
        }

        public Model.Soba Insert(SobeInsertRequest request)
        {
            var entity = _mapper.Map<Database.Soba>(request);



            _context.Sobe.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Soba>(entity);
        }

        public Model.Soba Update(int id, SobeInsertRequest request)
        {
            var entity = _context.Sobe.Find(id);
            _context.Sobe.Attach(entity);
            _context.Sobe.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Soba>(entity);
        }




    }
}
