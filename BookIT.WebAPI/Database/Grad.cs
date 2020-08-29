using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class Grad
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public Drzava Drzava { get; set; }
        public int DrzavaId { get; set; }

    }
}
