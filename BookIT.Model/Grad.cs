using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.Model
{
    public class Grad
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public Drzava Drzava { get; set; }
        public string Grad_Drzava { get => Naziv + ", " + Drzava?.Naziv; }
        public override string ToString()
        {
            return Naziv+", "+Drzava.Naziv;
        }

    }
}
