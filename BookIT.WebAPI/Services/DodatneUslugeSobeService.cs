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
    public class DodatneUslugeSobeService:IDodatneUslugeSobeService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public DodatneUslugeSobeService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.DodatnaUslugaSoba> Get(DodatneUslugeSobeSearchRequest request)
        {
            var query = _context.DodatneUslugeSobe.AsQueryable();
            if (request.SobaId!=0)
            {
                query = query.Where(x => x.SobaId==request.SobaId);
            }
            query = query.Include(x => x.DodatnaUsluga);

            var list = query.ToList();

            return _mapper.Map<List<Model.DodatnaUslugaSoba>>(list);
        }

        public Model.DodatnaUslugaSoba GetById(int id)
        {
            var entity = _context.DodatneUslugeSobe.Where(x => x.DodatnaUslugaSobaId == id)
                .FirstOrDefault();


            return _mapper.Map<Model.DodatnaUslugaSoba>(entity);
        }

        public Model.DodatnaUslugaSoba Insert(DodatneUslugeSobeInsertRequest request)
        {
            var entity = _mapper.Map<Database.DodatnaUslugaSoba>(request);



            _context.DodatneUslugeSobe.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.DodatnaUslugaSoba>(entity);
        }

        public Model.DodatnaUslugaSoba Update(int id, DodatneUslugeSobeInsertRequest request)
        {
            var entity = _context.DodatneUslugeSobe.Find(id);
            _context.DodatneUslugeSobe.Attach(entity);
            _context.DodatneUslugeSobe.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.DodatnaUslugaSoba>(entity);
        }




    }
}
