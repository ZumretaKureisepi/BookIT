using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class SmjestajiSlikeInsertRequest
    {
        public int SmjestajId { get; set; }

        public byte[] Slika { get; set; }

        public string Opis { get; set; }

    }
}
