using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IRezervacijeService
    {

        List<Model.Rezervacija> Get(RezervacijeSearchRequest request);

        Model.Rezervacija GetById(int id);

        Model.Rezervacija Insert(RezervacijeInsertRequest request);

        Model.Rezervacija Update(int id, RezervacijeUpdateRequest request);




    }
}
