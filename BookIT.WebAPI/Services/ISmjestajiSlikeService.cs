using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface ISmjestajiSlikeService
    {
        List<Model.SmjestajSlika> Get(SmjestajiSlikeSearchRequest request);

        Model.SmjestajSlika GetById(int id);

        Model.SmjestajSlika Insert(SmjestajiSlikeInsertRequest request);

        Model.SmjestajSlika Update(int id, SmjestajiSlikeInsertRequest request);

        Model.SmjestajSlika GetSmjestajSlika(int SmjestajId);


    }
}
