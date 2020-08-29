using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IDodatneUslugeRezervacijeService
    {
        List<Model.DodatnaUslugaRezervacija> Get(DodatneUslugeRezervacijeSearchRequest request);

        Model.DodatnaUslugaRezervacija GetById(int id);

        Model.DodatnaUslugaRezervacija Insert(DodatneUslugeRezervacijeInsertRequest request);

    }
}
