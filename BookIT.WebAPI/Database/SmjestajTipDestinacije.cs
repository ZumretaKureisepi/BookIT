using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class SmjestajTipDestinacije
    {
        public int SmjestajTipDestinacijeId { get; set; }

        public Smjestaj Smjestaj { get; set; }

        public int SmjestajId { get; set; }

        public TipDestinacije TipDestinacije { get; set; }
    }

    public enum TipDestinacije
    {
        Turistička, Egzotična, Avanturistička, Religiozna, Šoping, Kulinarska, Kulturološka
    }
}
