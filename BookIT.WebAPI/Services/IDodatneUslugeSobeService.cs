using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IDodatneUslugeSobeService
    {
        List<Model.DodatnaUslugaSoba> Get(DodatneUslugeSobeSearchRequest request);

        Model.DodatnaUslugaSoba GetById(int id);

        Model.DodatnaUslugaSoba Insert(DodatneUslugeSobeInsertRequest request);

        Model.DodatnaUslugaSoba Update(int id, DodatneUslugeSobeInsertRequest request);

    }
}
