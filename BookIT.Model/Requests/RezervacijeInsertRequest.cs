using System;
using System.Collections.Generic;
using System.Text;
using static BookIT.Model.Rezervacija;

namespace BookIT.Model.Requests
{
    public class RezervacijeInsertRequest
    {
        public DateTime DatumRezervacije { get; set; }
        public int SmjestajId { get; set; }
        public int BrojGostiju { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
