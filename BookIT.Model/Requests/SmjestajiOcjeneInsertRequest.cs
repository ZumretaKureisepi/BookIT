using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class SmjestajiOcjeneInsertRequest
    {

        public int SmjestajId { get; set; }

        public int OcjenaVlasnikSmjestaja { get; set; }
        public int OcjenaDodatneUsluge { get; set; }
        public int OcjenaIsplativost { get; set; }
        public int OcjenaLokacija { get; set; }
        public int OcjenaUdobnost { get; set; }
        public int OcjenaCistoca { get; set; }

        public string OcjenaOpisno { get; set; }




    }
}
