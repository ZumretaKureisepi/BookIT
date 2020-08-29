using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class SobeSlikeInsertRequest
    {
        public int SobaId { get; set; }

        public byte[] Slika { get; set; }

        public string Opis { get; set; }


    }
}
