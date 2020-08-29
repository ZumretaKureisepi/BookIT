using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class Soba
    {
        public int SobaId { get; set; }
        public string Naziv { get; set; }
        public int BrojMalihKreveta { get; set; }
        public int BrojVelikihKreveta { get; set; }
        public int VelicinaSobe { get; set; }
        [DataType(DataType.Currency)]
        public double Cijena { get; set; }
        public int SmjestajId { get; set; }
        public Smjestaj Smjestaj { get; set; }
    }
}
