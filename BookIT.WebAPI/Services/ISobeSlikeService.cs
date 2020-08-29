using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface ISobeSlikeService
    {

        List<Model.SobaSlika> Get(SobeSlikeSearchRequest request);

        Model.SobaSlika GetById(int id);

        Model.SobaSlika Insert(SobeSlikeInsertRequest request);

        Model.SobaSlika Update(int id, SobeSlikeInsertRequest request);

        Model.SobaSlika GetSobeSlika(int Sobaid);


    }
}
