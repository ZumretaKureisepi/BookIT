using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class Faktura
    {
        public int FakturaId { get; set; }
        public double Iznos { get; set; }
        public int RezervacijaId { get; set; }
        public Rezervacija Rezervacija { get; set; }
        public DateTime DatumFakture { get; set; }

    }
}
