using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model
{
    public class Korisnik_NoRelations
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

        public string Adresa { get; set; }
        public Grad Grad { get; set; }
        public int GradId { get; set; }
        public string BrojMobitela { get; set; }

    }
}
