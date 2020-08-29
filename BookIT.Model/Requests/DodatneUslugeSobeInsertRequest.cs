using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Model.Requests
{
    public class DodatneUslugeSobeInsertRequest
    {

        public int DodatnaUslugaId { get; set; }

        public int SobaId { get; set; }

        public float Cijena { get; set; }
    }
}
