using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IFaktureService
    {

        List<Model.Faktura> Get(FaktureSearchRequest request);

        Model.Faktura GetById(int id);

        Model.Faktura Insert(FaktureInsertRequest request);


    }
}
