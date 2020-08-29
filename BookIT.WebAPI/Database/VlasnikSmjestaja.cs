using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class VlasnikSmjestaja
    {   [ForeignKey("Korisnik")]
        public int Id { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public ICollection<Smjestaj> Smjestaj { get; set; }
    }
}
