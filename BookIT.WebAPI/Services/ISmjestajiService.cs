using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface ISmjestajiService
    {
        List<Model.Smjestaj> Get(SmjestajiSearchRequest request);

        Model.Smjestaj GetById(int id);

        Model.Smjestaj Insert(SmjestajiInsertRequest request);

        Model.Smjestaj Update(int id, SmjestajiInsertRequest request);

        List<Model.Smjestaj> ClientGet(SmjestajiClientSearchRequest request);

        double GetFinalnaOcjena(int id);

    }
}
