using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Mobile.Models
{
    public class OcjenaListItem
    {
        public int Ocjena { get; set; }
        public string VrstaOcjene { get; set; }

        public string Zvjezdica1 { get => Ocjena >= 1 ? "star_filled.png" : "star_empty.png"; }
        public string Zvjezdica2 { get => Ocjena >= 2 ? "star_filled.png" : "star_empty.png"; }
        public string Zvjezdica3 { get => Ocjena >= 3 ? "star_filled.png" : "star_empty.png"; }
        public string Zvjezdica4 { get => Ocjena >= 4 ? "star_filled.png" : "star_empty.png"; }
        public string Zvjezdica5 { get => Ocjena == 5 ? "star_filled.png" : "star_empty.png"; }
    }
}
