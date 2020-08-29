using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookIT.Model.Requests
{
    public class SobeInsertRequest
    {
        public string Naziv { get; set; }
        public int BrojMalihKreveta { get; set; }
        public int BrojVelikihKreveta { get; set; }
        public int VelicinaSobe { get; set; }
        [DataType(DataType.Currency)]
        public double Cijena { get; set; }
        public int SmjestajId { get; set; }

    }
}
