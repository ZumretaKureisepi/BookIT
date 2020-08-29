using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class Korisnik
    {
        [Key]
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Adresa { get; set; }
        public Grad Grad { get; set; }
        public int GradId { get; set; }
        public string BrojMobitela { get; set; }
        public virtual VlasnikSmjestaja VlasnikSmjestaja { get; set; }
        public virtual Klijent Klijent { get; set; }

        public Uloga Uloga { get; set; }
        public int UlogaId { get; set; }
    }
}
