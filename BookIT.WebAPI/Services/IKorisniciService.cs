using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnik> Get(KorisniciSearchRequest request);

        Model.Korisnik GetById(int id);

        Model.Korisnik Insert(KorisniciInsertRequest request);

        Model.Korisnik Update(int id, KorisniciUpdateRequest request);

        Model.Korisnik Authenticiraj(string email, string pass);

        Model.Korisnik GetCurrentUser();

        Model.Korisnik Register(KorisniciRegistracijaRequest request);


    }
}
