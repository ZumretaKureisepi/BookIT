using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.Model
{
    public class Smjestaj
    {
        public int SmjestajId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public Grad Grad { get; set; }
        public int GradId { get; set; }
        public VlasnikSmjestaja VlasnikSmjestaja { get; set; }
        public int VlasnikSmjestajaId { get; set; }
        public TipSmjestaja TipSmjestaja { get; set; }
        public double? Cijena { get; set; }
        public string CijenaText { get => Cijena?.ToString("0.00") + " KM"; }
        public string Opis { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public ICollection<SmjestajTipDestinacije> SmjestajTipDestinacije { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
        public string Lokacija { get => Adresa + ", " + Grad; }
    }
    public enum TipSmjestaja
    {
        Apartman, Hotel, Hostel, Vila, Kuca, Motel
    }
}
