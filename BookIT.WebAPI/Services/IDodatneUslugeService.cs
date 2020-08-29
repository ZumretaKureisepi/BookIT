using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IDodatneUslugeService
    {
        List<Model.DodatnaUsluga> Get(DodatneUslugeSearchRequest request);

        Model.DodatnaUsluga GetById(int id);

        Model.DodatnaUsluga Insert(DodatneUslugeInsertRequest request);

        Model.DodatnaUsluga Update(int id, DodatneUslugeInsertRequest request);
    }
}
