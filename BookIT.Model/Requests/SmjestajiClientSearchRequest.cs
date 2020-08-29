using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class SmjestajiClientSearchRequest
    {
        public string Lokacija { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        //public int Sobe { get; set; }
        public int Odrasli { get; set; }
        public int Djeca { get; set; }

    }
}
