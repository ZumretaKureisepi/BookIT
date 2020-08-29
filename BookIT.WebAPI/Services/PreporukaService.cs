using AutoMapper;
using BookIT.WebAPI.Database;
using BookIT.WebAPI.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public class PreporukaService: IPreporukaService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;

        private int minOcjena = 2;
        private int brojPreporucenihSmjestaja = 3;

        public PreporukaService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Smjestaj> PreporuciSmjestaje()
        {
            int KlijentId = BasicAuthenticationHandler.user.KorisnikId;

            try
            {
                if (KlijentId == 0)
                {
                    throw new Exception();
                }

                List<SmjestajOcjena> listOcjena = _context.SmjestajiOcjene.Where(x => x.KlijentId == KlijentId)
                    .Include(m => m.Smjestaj)
                    .AsNoTracking()
                    .ToList();

                var pozitivneOcjene = listOcjena.Where(item => item.FinalnaOcjena >= minOcjena).ToList();

                if (pozitivneOcjene.Count() > 0)
                {
                    List<TipDestinacije> jedinstveniTipoviDestinacije = new List<TipDestinacije>();
                    foreach (var item in pozitivneOcjene)
                    {
                        var itemTipoviDestinacija = _context.SmjestajiTipDestinacija.Where(m => m.SmjestajId == item.SmjestajId)
                            .Select(g => g.TipDestinacije)
                            .ToList();

                        foreach (var tipDestinacije in itemTipoviDestinacija)
                        {
                            bool canBeAdded = true;
                            for (int i = 0; i < jedinstveniTipoviDestinacije.Count; i++)
                            {
                                if (tipDestinacije == jedinstveniTipoviDestinacije.ElementAt(i))
                                {
                                    canBeAdded = false;
                                }
                            }

                            if (canBeAdded)
                            {
                                jedinstveniTipoviDestinacije.Add(tipDestinacije);
                            }
                        }
                    }

                    List<Smjestaj> listToReturn = new List<Smjestaj>();
                    foreach (var item in jedinstveniTipoviDestinacije)
                    {
                        var smjestajiByTipDestinacije = _context.SmjestajiTipDestinacija
                            .Where(g => g.TipDestinacije == item)
                            .Include(m => m.Smjestaj)
                            .Select(x => x.Smjestaj)
                            .AsNoTracking()
                            .ToList();
                        foreach (var smjestaj in smjestajiByTipDestinacije)
                        {
                            bool canBeAdded = true;
                            for (int i = 0; i < listToReturn.Count; i++)
                            {
                                if (smjestaj.SmjestajId == listToReturn.ElementAt(i).SmjestajId)
                                {
                                    canBeAdded = false;
                                }
                            }

                            foreach (var ocjene in listOcjena)
                            {
                                if (ocjene.SmjestajId == smjestaj.SmjestajId)
                                    canBeAdded = false;
                            }

                            if (canBeAdded)
                            {
                                listToReturn.Add(smjestaj);
                            }
                        }
                    }

                    var listPreporuceniSmjestaji = listToReturn.OrderBy(Smjestaj => Guid.NewGuid()).Take(brojPreporucenihSmjestaja).ToList();

                    return _mapper.Map<List<Model.Smjestaj>>(listPreporuceniSmjestaji);
                }
                throw new Exception();
            }
            catch
            {
                var listPreporuceniSmjestaji = _context.Smjestaji.AsNoTracking().OrderBy(Smjestaj => Guid.NewGuid()).Take(brojPreporucenihSmjestaja).ToList();

                return _mapper.Map<List<Model.Smjestaj>>(listPreporuceniSmjestaji);

            }

        }

    }
}
