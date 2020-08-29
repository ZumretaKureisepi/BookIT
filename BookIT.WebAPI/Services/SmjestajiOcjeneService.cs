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
    public class SmjestajiOcjeneService: ISmjestajiOcjeneService
    {

        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public SmjestajiOcjeneService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.SmjestajOcjena> Get(SmjestajiOcjeneSearchRequest request)
        {
            var query = _context.SmjestajiOcjene.AsQueryable();
            if (request.SmjestajId != 0)
            {
                query = query.Where(x => (x.SmjestajId == request.SmjestajId));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.SmjestajOcjena>>(list);
        }

        public List<Model.SmjestajOcjena> GetMyReviews(SmjestajiOcjeneSearchRequest request)
        {
            var query = _context.SmjestajiOcjene.AsQueryable();
            if (request.SmjestajId != 0)
            {
                query = query.Where(x => (x.SmjestajId == request.SmjestajId));
            }
            query = query.Where(x => x.KlijentId == BasicAuthenticationHandler.user.KorisnikId);

            var list = query.ToList();

            return _mapper.Map<List<Model.SmjestajOcjena>>(list);
        }

        public Model.SmjestajOcjena GetById(int id)
        {
            var entity = _context.SmjestajiOcjene.Where(x => x.SmjestajOcjenaId == id)
                .FirstOrDefault();

            return _mapper.Map<Model.SmjestajOcjena>(entity);
        }

        public Model.SmjestajOcjena Insert(SmjestajiOcjeneInsertRequest request)
        {
            var entity = _mapper.Map<Database.SmjestajOcjena>(request);

            entity.DatumOcjene = DateTime.Now;
            double sum = 0;
            sum += entity.OcjenaCistoca;
            sum += entity.OcjenaDodatneUsluge;
            sum += entity.OcjenaIsplativost;
            sum += entity.OcjenaLokacija;
            sum += entity.OcjenaUdobnost;
            sum += entity.OcjenaVlasnikSmjestaja;

            entity.FinalnaOcjena = Math.Round(sum / 6, 2);
            entity.KlijentId = BasicAuthenticationHandler.user.KorisnikId;

            _context.SmjestajiOcjene.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.SmjestajOcjena>(entity);
        }





    }
}
