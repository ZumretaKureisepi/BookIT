using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IGradoviService
    {
        List<Model.Grad> Get(GradoviSearchRequest request);

        Model.Grad GetById(int id);

        Model.Grad Insert(GradoviInsertRequest request);

        Model.Grad Update(int id, GradoviInsertRequest request);

    }
}
