using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.Model
{
    public class Faktura
    {
        public int FakturaId { get; set; }
        public double Iznos { get; set; }
        public int RezervacijaId { get; set; }
        public Rezervacija Rezervacija { get; set; }
        public DateTime DatumFakture { get; set; }
        public int RedniBroj { get; set; }
        public string IznosStr => Iznos.ToString("0.00") + " KM";

        public string ImePrezimeKlijent { get => Rezervacija?.Klijent?.ToString(); }
        public string BrojFakture {
            get{
                if(RedniBroj>0)
                return "Faktura #" + RedniBroj;
                return "Faktura #" + FakturaId;
            } }
    }
}
