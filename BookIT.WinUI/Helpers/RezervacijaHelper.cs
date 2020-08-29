using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookIT.WinUI
{

    public class RezervacijaHelper
    {
        private static readonly APIService _apiServiceDodatneUslugeRezervacije = new APIService("DodatneUslugeRezervacije");
        private static readonly APIService _apiServiceSobeRezervacije = new APIService("SobeRezervacije");

        public static async Task<Model.Rezervacija> GetCijenaRezervacijeINaziveSoba(Model.Rezervacija rezervacija)
        {
            bool IsApartman;

            switch (rezervacija.Smjestaj.TipSmjestaja)
            {
                case Model.TipSmjestaja.Apartman:
                case Model.TipSmjestaja.Vila:
                case Model.TipSmjestaja.Kuca:
                    IsApartman = true;
                    break;
                default:
                    IsApartman = false;
                    break;
            }



            // Get sve dodatne usluge koje su odabrane u rezervaciji
            var search_dodatneUslugeRezervacije = new Model.Requests.DodatneUslugeRezervacijeSearchRequest
            {
                RezervacijaId = rezervacija.RezervacijaId
            };
            var resultDodatneUslugeRezervacije = await _apiServiceDodatneUslugeRezervacije.Get<List<Model.DodatnaUslugaRezervacija>>(search_dodatneUslugeRezervacije);

            foreach (Model.DodatnaUslugaRezervacija item in resultDodatneUslugeRezervacije)
            {
                rezervacija.Cijena += item.Cijena;
            }

            //rezervacija.Cijena += resultSobeRezervacije.Sum(x => x.Cijena);
            //rezervacija.Cijena += resultDodatneUslugeRezervacije.Sum(x => x.Cijena);

            if (IsApartman)
            {
                rezervacija.Cijena += rezervacija.Smjestaj.Cijena.Value;
            }
            else
            {
                // Get sve sobe koje su odabrane u rezervaciji
                var search_sobeRezervacije = new Model.Requests.SobeRezervacijeSearchRequest
                {
                    RezervacijaId = rezervacija.RezervacijaId
                };
                var resultSobeRezervacije = await _apiServiceSobeRezervacije.Get<List<Model.SobaRezervacija>>(search_sobeRezervacije);

                // sum the prices of selected rooms and facilities to get the final price

                rezervacija.Sobe = null;

                foreach (Model.SobaRezervacija item in resultSobeRezervacije)
                {
                    rezervacija.Cijena += item.Cijena;
                    if (rezervacija.Sobe == null)
                        rezervacija.Sobe += item.Soba.Naziv;
                    else
                        rezervacija.Sobe += ", " + item.Soba.Naziv;
                }

            }

            double NumOfDays = Math.Ceiling((rezervacija.CheckOutDate - rezervacija.CheckInDate).TotalDays);
            rezervacija.Cijena *= NumOfDays;

            return rezervacija;
        }



    }
}
