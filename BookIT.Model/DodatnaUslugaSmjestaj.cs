using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model
{
    public class DodatnaUslugaSmjestaj
    {
        public int DodatnaUslugaSmjestajId { get; set; }

        public DodatnaUsluga DodatnaUsluga { get; set; }

        public Smjestaj Smjestaj { get; set; }

        public float Cijena { get; set; }


    }
}
