using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class Klijent
    {   [ForeignKey("Korisnik")]
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public ICollection<Rezervacija> Rezervacija { get; set; }

    }
}
