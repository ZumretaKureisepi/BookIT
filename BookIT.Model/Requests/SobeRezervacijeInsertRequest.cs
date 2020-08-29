using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class SobeRezervacijeInsertRequest
    {
        public int SobaId { get; set; }
        public int RezervacijaId { get; set; }
    }
}
