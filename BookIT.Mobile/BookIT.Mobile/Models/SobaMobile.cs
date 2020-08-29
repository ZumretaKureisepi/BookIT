using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.Mobile.Models
{
    public class SobaMobile
    {
        public int SobaId { get; set; }
        public string Naziv { get; set; }
        public int BrojMalihKreveta { get; set; }
        public int BrojVelikihKreveta { get; set; }
        public int VelicinaSobe { get; set; }
        public string VelicinaSobeText { get => VelicinaSobe + " m²"; }
        [DataType(DataType.Currency)]
        public double Cijena { get; set; }
        public string CijenaBoravkaText { get; set; }
        public bool Odabrana { get; set; }
        public byte[] Slika { get; set; }
        public string OdaberiSobuText { get; set; } = "Odaberite sobu";
        public List<DodatnaUslugaSwitchCellItem> ListDodatneUsluge { get; set; } = new List<DodatnaUslugaSwitchCellItem>();
        public string MaxBrojLjudi
        {
            get {
                int max = BrojMalihKreveta + (BrojVelikihKreveta * 2);
                string str = max.ToString();
                if (max == 1)
                    str += " osobu";
                else if (max >= 2 && max <= 4)
                    str += " osobe";
                else if (max >= 5)
                    str += " osoba";

                return str;
            }
        }
        public string strKreveti
        {
            get
            {
                string str = "";

                if (BrojVelikihKreveta > 0)
                {
                    str += BrojVelikihKreveta.ToString();
                    if (BrojVelikihKreveta == 1)
                        str += " veliki krevet";
                    else if (BrojVelikihKreveta >= 2 && BrojVelikihKreveta <= 4)
                        str += " velika kreveta";
                    else
                        str += " velikih kreveta";
                }


                if (BrojMalihKreveta > 0)
                {
                    if (str != "")
                        str += ", ";

                    str += BrojMalihKreveta.ToString();
                    if (BrojMalihKreveta == 1)
                        str += " mali krevet";
                    else if (BrojMalihKreveta >= 2 && BrojMalihKreveta <= 4)
                        str += " mala kreveta";
                    else
                        str += " malih kreveta";
                }


                return str;

            }
        }
        public string strDodatneUsluge { get; set; }
    }
}
