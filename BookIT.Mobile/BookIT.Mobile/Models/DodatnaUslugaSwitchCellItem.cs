using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Mobile.Models
{
    public class DodatnaUslugaSwitchCellItem
    {
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string NazivCijena { get => Naziv + " (" + Cijena.ToString("0.00") + " KM po danu)"; }
        public int DodatnaUslugaId { get; set; }
        public bool Checked { get; set; }
    }
}
