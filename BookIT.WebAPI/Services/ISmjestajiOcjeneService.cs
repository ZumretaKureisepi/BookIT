using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface ISmjestajiOcjeneService
    {

        List<Model.SmjestajOcjena> Get(SmjestajiOcjeneSearchRequest request);

        Model.SmjestajOcjena GetById(int id);

        List<Model.SmjestajOcjena> GetMyReviews(SmjestajiOcjeneSearchRequest request);

        Model.SmjestajOcjena Insert(SmjestajiOcjeneInsertRequest request);

        //List<Model.SmjestajOcjena> ClientGet(SmjestajiOcjeneClientSearchRequest request);






    }
}
