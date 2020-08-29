using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BookIT.Model
{
    public class DodatnaUslugaRezervacija
    {
        public int DodatnaUslugaRezervacijaId { get; set; }
        public int DodatnaUslugaId { get; set; }
        public DodatnaUsluga DodatnaUsluga { get; set; }
        public int RezervacijaId { get; set; }
        public Rezervacija Rezervacija { get; set; }
        public double Cijena { get; set; }
        public string CijenaStr => Cijena.ToString("0.00") + " KM";
        public int? SobaId { get; set; }
        public Soba Soba { get; set; }
    }
}
