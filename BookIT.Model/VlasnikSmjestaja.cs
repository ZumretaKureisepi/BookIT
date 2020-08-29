using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.Model
{
    public class VlasnikSmjestaja
    {   [ForeignKey("Korisnik")]
        public int Id { get; set; }
        public virtual Korisnik_NoRelations Korisnik { get; set; }

        public override string ToString()
        {
            // Korisnik?. znaci ako je objekat Korisnik null, nece pucati zbog pristupa property-ju Ime
            return Korisnik?.Ime + " " + Korisnik?.Prezime;
        }
    }
}
