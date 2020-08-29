using BookIT.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Mobile.Models
{
    public class RezervacijaMobile
    {
        public int RezervacijaId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public eStanje Status { get; set; }
        public string StatusText { get
            {
                if (Status == eStanje.CekanjePotvrde)
                    return "Čekanje potvrde";
                if (Status == eStanje.CekanjeUplate)
                    return "Čekanje uplate";

                return Status.ToString();
            }
        }
        public int SmjestajId { get; set; }
        public Smjestaj Smjestaj { get; set; }
        public int BrojGostiju { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int KlijentId { get; set; }
        public Klijent Klijent { get; set; }
        public ICollection<SobaRezervacija> SobaRezervacija { get; set; }
        public ICollection<DodatnaUslugaRezervacija> DodatnaUslugaRezervacija { get; set; }
        public bool MozePlatiti { get; set; }
        public bool MozeOtkazati { get; set; }
        public bool MozeOcijeniti { get; set; }


        public enum eStanje
        {
            CekanjePotvrde, Odbijena, CekanjeUplate, Finalizirana, Otkazana
        }


    }
}
