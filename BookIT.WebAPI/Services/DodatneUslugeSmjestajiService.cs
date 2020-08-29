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
    public class DodatneUslugeSmjestajiService:IDodatneUslugeSmjestajiService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public DodatneUslugeSmjestajiService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.DodatnaUslugaSmjestaj> Get(DodatneUslugeSmjestajiSearchRequest request)
        {
            var query = _context.DodatneUslugeSmjestaji.AsQueryable();
            if (request.SmjestajId!=0)
            {
                query = query.Where(x => x.SmjestajId==request.SmjestajId);
            }
            query = query.Include(x => x.DodatnaUsluga);

            var list = query.ToList();

            return _mapper.Map<List<Model.DodatnaUslugaSmjestaj>>(list);
        }

        public Model.DodatnaUslugaSmjestaj GetById(int id)
        {
            var entity = _context.DodatneUslugeSmjestaji.Where(x => x.DodatnaUslugaSmjestajId == id)
                .FirstOrDefault();


            return _mapper.Map<Model.DodatnaUslugaSmjestaj>(entity);
        }

        public Model.DodatnaUslugaSmjestaj Insert(DodatneUslugeSmjestajiInsertRequest request)
        {
            var entity = _mapper.Map<Database.DodatnaUslugaSmjestaj>(request);



            _context.DodatneUslugeSmjestaji.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.DodatnaUslugaSmjestaj>(entity);
        }

        public Model.DodatnaUslugaSmjestaj Update(int id, DodatneUslugeSmjestajiInsertRequest request)
        {
            var entity = _context.DodatneUslugeSmjestaji.Find(id);
            _context.DodatneUslugeSmjestaji.Attach(entity);
            _context.DodatneUslugeSmjestaji.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.DodatnaUslugaSmjestaj>(entity);
        }




    }
}
