using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class DodatneUslugeSmjestajiInsertRequest
    {

        public int DodatnaUslugaId { get; set; }

        public int SmjestajId { get; set; }

        public float Cijena { get; set; }
    }
}
