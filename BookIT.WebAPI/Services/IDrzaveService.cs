using BookIT.Model;
using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IDrzaveService
    {

        List<Model.Drzava> Get();

        Model.Drzava Insert(DrzaveInsertRequest request);

    }
}
