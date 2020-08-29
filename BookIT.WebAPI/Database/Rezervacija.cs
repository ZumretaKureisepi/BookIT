using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class Rezervacija
    {
        public int RezervacijaId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public eStanje Status { get; set; }
        public int SmjestajId { get; set; }
        public Smjestaj Smjestaj { get; set; }
        public int BrojGostiju { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int KlijentId { get; set; }
        public Klijent Klijent { get; set; }
        public ICollection<SobaRezervacija> SobaRezervacija { get; set; }
        public ICollection<DodatnaUslugaRezervacija> DodatnaUslugaRezervacija { get; set; }


        public enum eStanje
        {
            CekanjePotvrde, Odbijena, CekanjeUplate, Finalizirana, Otkazana
        }
        

    }
}
