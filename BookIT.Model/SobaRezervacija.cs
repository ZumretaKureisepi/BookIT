using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.Model
{
    public class SobaRezervacija
    {
        public int SobaRezervacijaId { get; set; }
        public int SobaId { get; set; }
        public Soba Soba { get; set; }
        public int RezervacijaId { get; set; }
        public Rezervacija Rezervacija { get; set; }
        public double Cijena { get; set; }
    }

}
