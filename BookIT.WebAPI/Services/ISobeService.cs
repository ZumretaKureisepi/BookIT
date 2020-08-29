using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface ISobeService
    {
        List<Model.Soba> Get(SobeSearchRequest request);

        Model.Soba GetById(int id);

        Model.Soba Insert(SobeInsertRequest request);

        Model.Soba Update(int id, SobeInsertRequest request);



    }
}
