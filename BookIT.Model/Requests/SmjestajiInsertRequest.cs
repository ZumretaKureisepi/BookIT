using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class SmjestajiInsertRequest
    {
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public int GradId { get; set; }
        public TipSmjestaja TipSmjestaja { get; set; }
        public double? Cijena { get; set; }
        public string Opis { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public ICollection<SmjestajTipDestinacije> SmjestajTipDestinacije { get; set; }
    }
}
