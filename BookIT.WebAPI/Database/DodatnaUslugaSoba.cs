using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class DodatnaUslugaSoba
    {
        public int DodatnaUslugaSobaId { get; set; }

        public DodatnaUsluga DodatnaUsluga { get; set; }

        public int DodatnaUslugaId { get; set; }

        public Soba Soba { get; set; }

        public int SobaId { get; set; }

        public float Cijena { get; set; }
    }
}
