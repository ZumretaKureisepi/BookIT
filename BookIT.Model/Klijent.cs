using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.Model
{
    public class Klijent
    {   [ForeignKey("Korisnik")]
        public int Id { get; set; }
        public Korisnik_NoRelations Korisnik { get; set; }
        // public ICollection<Rezervacija> Rezervacija { get; set; }

        public override string ToString()
        {
            return Korisnik?.Ime + " " + Korisnik?.Prezime;
        }
    }
}
