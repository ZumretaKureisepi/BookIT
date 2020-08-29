using System;
using System.Collections.Generic;
using System.Text;
using static BookIT.Model.Rezervacija;

namespace BookIT.Model.Requests
{
    public class RezervacijeUpdateRequest
    {
        public eStanje Status { get; set; }
    }
}
