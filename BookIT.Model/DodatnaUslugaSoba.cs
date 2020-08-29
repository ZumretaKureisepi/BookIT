using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model
{
    public class DodatnaUslugaSoba
    {
        public int DodatnaUslugaSobaId { get; set; }

        public DodatnaUsluga DodatnaUsluga { get; set; }

        public Soba Soba { get; set; }

        public float Cijena { get; set; }


    }
}
