using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.Model
{
    public class SobaSlika
    {
        public int SobaSlikaId { get; set; }

        public int SobaId { get; set; }

        public Model.Soba Soba { get; set; }

        public byte[] Slika { get; set; }

        public string Opis { get; set; }


    }
}
