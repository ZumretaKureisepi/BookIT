using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class Smjestaj
    {
        public int SmjestajId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }
        public int VlasnikSmjestajaId { get; set; }
        public VlasnikSmjestaja VlasnikSmjestaja { get; set; }
        public TipSmjestaja TipSmjestaja { get; set; }
        public double? Cijena { get; set; }
        public string Opis { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public ICollection<SmjestajTipDestinacije> SmjestajTipDestinacije { get; set; }
    }
    public enum TipSmjestaja
    {
        Apartman, Hotel, Hostel, Vila, Kuca, Motel
    }
    
}
