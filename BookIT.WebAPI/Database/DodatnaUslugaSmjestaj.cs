using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class DodatnaUslugaSmjestaj
    {
        public int DodatnaUslugaSmjestajId { get; set; }

        public DodatnaUsluga DodatnaUsluga { get; set; }

        public int DodatnaUslugaId { get; set; }

        public Smjestaj Smjestaj { get; set; }

        public int SmjestajId { get; set; }

        public float Cijena { get; set; }
    }
}
