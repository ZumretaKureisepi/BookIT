using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IUlogeService
    {
        List<Model.Uloga> Get();

        Model.Uloga GetById(int id);

    }
}
