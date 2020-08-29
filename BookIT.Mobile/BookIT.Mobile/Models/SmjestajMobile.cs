using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Mobile.Models
{
    public class SmjestajMobile
    {
        public int SmjestajId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public Model.Grad Grad { get; set; }
        public int GradId { get; set; }
        public Model.VlasnikSmjestaja VlasnikSmjestaja { get; set; }
        public int VlasnikSmjestajaId { get; set; }
        public TipSmjestaja TipSmjestaja { get; set; }
        public string FinalnaOcjenaStr { get; set; }
        public string OcjenaOpis { get; set; }
        public string Opis { get; set; }


        public override string ToString()
        {
            return Naziv;
        }
        public string Lokacija { get => Adresa + ", " + Grad; }
        public byte[] Slika { get; set; }
    }
    public enum TipSmjestaja
    {
        Apartman, Hotel, Hostel, Vila, Kuca, Motel
    }
}
