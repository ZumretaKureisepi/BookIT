using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface ISobeRezervacijeService
    {
        List<Model.SobaRezervacija> Get(SobeRezervacijeSearchRequest request);

        Model.SobaRezervacija GetById(int id);

        Model.SobaRezervacija Insert(SobeRezervacijeInsertRequest request);

    }
}
