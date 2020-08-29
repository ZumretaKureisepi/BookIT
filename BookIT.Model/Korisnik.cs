using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

        public string Adresa { get; set; }
        public Grad Grad { get; set; }
        public int GradId { get; set; }
        public string BrojMobitela { get; set; }
        public virtual VlasnikSmjestaja VlasnikSmjestaja { get; set; }
        public virtual Klijent Klijent { get; set; }

        public Uloga Uloga { get; set; }
        public int UlogaId { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }
}
