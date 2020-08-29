using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class SmjestajSlika
    {
        public int SmjestajSlikaId { get; set; }

        public int SmjestajId { get; set; }

        public Smjestaj Smjestaj { get; set; }

        public byte[] Slika { get; set; }

        public string Opis { get; set; }
    }
}
