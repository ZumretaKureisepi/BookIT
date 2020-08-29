using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class DodatneUslugeRezervacijeInsertRequest
    {
        public int DodatnaUslugaId { get; set; }
        public int RezervacijaId { get; set; }
        public int? SobaId { get; set; }
    }
}
