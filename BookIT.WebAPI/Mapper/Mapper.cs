using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.Korisnik, Model.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Requests.KorisniciUpdateRequest>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Requests.KorisniciRegistracijaRequest>().ReverseMap();


            CreateMap<Database.Smjestaj, Model.Smjestaj>();
            CreateMap<Database.Smjestaj, Model.Requests.SmjestajiInsertRequest>().ReverseMap();

            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Grad, Model.Requests.GradoviInsertRequest>().ReverseMap();


            CreateMap<Database.Soba, Model.Soba>();
            CreateMap<Database.Soba, Model.Requests.SobeInsertRequest>().ReverseMap();


            CreateMap<Database.DodatnaUsluga, Model.DodatnaUsluga>();
            CreateMap<Database.DodatnaUsluga, Model.Requests.DodatneUslugeInsertRequest>().ReverseMap();


            CreateMap<Database.DodatnaUslugaSmjestaj, Model.DodatnaUslugaSmjestaj>();
            CreateMap<Database.DodatnaUslugaSmjestaj, Model.Requests.DodatneUslugeSmjestajiInsertRequest>().ReverseMap();


            CreateMap<Database.Faktura, Model.Faktura>();
            CreateMap<Database.Faktura, Model.Requests.FaktureInsertRequest>().ReverseMap();

            CreateMap<Database.DodatnaUslugaRezervacija, Model.DodatnaUslugaRezervacija>();
            CreateMap<Database.DodatnaUslugaRezervacija, Model.Requests.DodatneUslugeRezervacijeInsertRequest>().ReverseMap();


            CreateMap<Database.SobaRezervacija, Model.SobaRezervacija>();
            CreateMap<Database.SobaRezervacija, Model.Requests.SobeRezervacijeInsertRequest>().ReverseMap();


            CreateMap<Database.Rezervacija, Model.Rezervacija>();
            CreateMap<Database.Rezervacija, Model.Requests.RezervacijeInsertRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, Model.Requests.RezervacijeUpdateRequest>().ReverseMap();


            CreateMap<Database.Uloga, Model.Uloga>();

            CreateMap<Database.Drzava, Model.Drzava>();
            CreateMap<Database.Drzava, Model.Requests.DrzaveInsertRequest>().ReverseMap();

            CreateMap<Database.DodatnaUslugaSoba, Model.DodatnaUslugaSoba>();
            CreateMap<Database.DodatnaUslugaSoba, Model.Requests.DodatneUslugeSobeInsertRequest>().ReverseMap();

            CreateMap<Database.SmjestajSlika, Model.SmjestajSlika>();
            CreateMap<Database.SmjestajSlika, Model.Requests.SmjestajiSlikeInsertRequest>().ReverseMap();

            CreateMap<Database.SobaSlika, Model.SobaSlika>();
            CreateMap<Database.SobaSlika, Model.Requests.SobeSlikeInsertRequest>().ReverseMap();

            CreateMap<Database.SmjestajOcjena, Model.SmjestajOcjena>();
            CreateMap<Database.SmjestajOcjena, Model.Requests.SmjestajiOcjeneInsertRequest>().ReverseMap();

            CreateMap<Database.SmjestajTipDestinacije, Model.SmjestajTipDestinacije>();
            CreateMap<Model.SmjestajTipDestinacije, Database.SmjestajTipDestinacije>();

        }
    }
}
