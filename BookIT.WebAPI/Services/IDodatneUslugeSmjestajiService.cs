using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IDodatneUslugeSmjestajiService
    {
        List<Model.DodatnaUslugaSmjestaj> Get(DodatneUslugeSmjestajiSearchRequest request);

        Model.DodatnaUslugaSmjestaj GetById(int id);

        Model.DodatnaUslugaSmjestaj Insert(DodatneUslugeSmjestajiInsertRequest request);

        Model.DodatnaUslugaSmjestaj Update(int id, DodatneUslugeSmjestajiInsertRequest request);

    }
}
