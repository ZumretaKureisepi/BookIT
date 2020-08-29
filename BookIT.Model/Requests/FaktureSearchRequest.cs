using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class FaktureSearchRequest
    {
        public string ImeKlijenta { get; set; }
        public int RezervacijaId { get; set; }
    }
}
