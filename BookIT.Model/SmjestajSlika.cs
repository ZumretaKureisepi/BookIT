using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.Model
{
    public class SmjestajSlika
    {
        public int SmjestajSlikaId { get; set; }

        public int SmjestajId { get; set; }

        public Model.Smjestaj Smjestaj { get; set; }

        public byte[] Slika { get; set; }

        public string Opis { get; set; }
    }
}
