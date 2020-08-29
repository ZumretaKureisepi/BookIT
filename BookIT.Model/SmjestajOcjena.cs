using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.Model
{
    public class SmjestajOcjena
    {
        public int SmjestajOcjenaId { get; set; }

        public int SmjestajId { get; set; }

        public Smjestaj Smjestaj { get; set; }

        public int KlijentId { get; set; }

        public Klijent Klijent { get; set; }

        public int OcjenaVlasnikSmjestaja { get; set; }
        public int OcjenaDodatneUsluge { get; set; }
        public int OcjenaIsplativost { get; set; }
        public int OcjenaLokacija { get; set; }
        public int OcjenaUdobnost { get; set; }
        public int OcjenaCistoca { get; set; }

        public DateTime DatumOcjene { get; set; }

        public string OcjenaOpisno { get; set; }

        public double FinalnaOcjena { get; set; }

    }
}
