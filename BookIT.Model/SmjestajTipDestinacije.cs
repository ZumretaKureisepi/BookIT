using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model
{
    public class SmjestajTipDestinacije
    {
        public int SmjestajTipDestinacijeId { get; set; }

        public int SmjestajId { get; set; }

        public TipDestinacije TipDestinacije { get; set; }
    }

    public enum TipDestinacije
    {
        Turistička, Egzotična, Avanturistička, Religiozna, Šoping, Kulinarska, Kulturološka
    }
}
