using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class FaktureInsertRequest
    {
        public double Iznos { get; set; }
        public int RezervacijaId { get; set; }
        public DateTime DatumFakture { get; set; }

    }
}
