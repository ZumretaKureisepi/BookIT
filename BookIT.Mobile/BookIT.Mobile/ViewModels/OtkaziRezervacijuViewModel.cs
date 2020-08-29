using BookIT.Mobile.Models;
using BookIT.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class OtkaziRezervacijuViewModel: BaseViewModel
    {
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        private readonly APIService _serviceDodatneUslugeRezervacije = new APIService("DodatneUslugeRezervacije");
        private readonly APIService _serviceSobeRezervacije = new APIService("SobeRezervacije");

        public OtkaziRezervacijuViewModel(int RezervacijaId, Xamarin.Forms.INavigation navigation)
        {
            Navigation = navigation;
            _rezervacijaId = RezervacijaId;
            OtkaziteCommand = new Command(async () => await Otkazite());
            Title = "Otkazivanje rezervacije";
        }

        private async Task Otkazite()
        {
            var request = new Model.Requests.RezervacijeUpdateRequest
            {
                Status = Model.Rezervacija.eStanje.Otkazana
            };
            var entity = await _serviceRezervacije.Update<Model.Rezervacija>(_rezervacijaId, request);
            if (entity != null)
            {
                Application.Current.MainPage = new OtkazanaRezervacijaPage();
            }

        }
        public bool IsApartman { get; set; }
        public async Task Init()
        {
            Rezervacija = await _serviceRezervacije.GetById<Model.Rezervacija>(_rezervacijaId);
            int numOfDays = (int)Math.Ceiling((Rezervacija.CheckOutDate - Rezervacija.CheckInDate).TotalDays);

            switch (Rezervacija.Smjestaj.TipSmjestaja)
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

            var request1 = new Model.Requests.DodatneUslugeRezervacijeSearchRequest
            {
                RezervacijaId = _rezervacijaId
            };
            var ListDodatneUslugeRezervacije = await _serviceDodatneUslugeRezervacije.Get<List<Model.DodatnaUslugaRezervacija>>(request1);
            double Total = 0;
            Stavke.Clear();

            if (IsApartman)
            {
                Stavke.Add(new StavkaFakture
                {
                    Naziv = Rezervacija.Smjestaj.Naziv,
                    Cijena = Rezervacija.Smjestaj.Cijena.Value * numOfDays
                });
                Total += Rezervacija.Smjestaj.Cijena.Value * numOfDays;
                foreach (var usluga in ListDodatneUslugeRezervacije)
                {
                    Stavke.Add(new StavkaFakture
                    {
                        Naziv = usluga.DodatnaUsluga.Naziv,
                        Cijena = usluga.Cijena * numOfDays
                    });
                    Total += usluga.Cijena * numOfDays;
                }

            }
            else
            {
                var request2 = new Model.Requests.SobeRezervacijeSearchRequest
                {
                    RezervacijaId = _rezervacijaId
                };
                var ListSobeRezervacije = await _serviceSobeRezervacije.Get<List<Model.SobaRezervacija>>(request2);
                foreach (var soba in ListSobeRezervacije)
                {
                    Stavke.Add(new StavkaFakture
                    {
                        Naziv = soba.Soba.Naziv,
                        Cijena = soba.Cijena * numOfDays
                    });
                    Total += soba.Cijena * numOfDays;
                    foreach (var usluga in ListDodatneUslugeRezervacije)
                    {
                        if (usluga.SobaId == soba.SobaId)
                        {
                            Stavke.Add(new StavkaFakture
                            {
                                Naziv = usluga.DodatnaUsluga.Naziv,
                                Cijena = usluga.Cijena * numOfDays
                            });
                            Total += usluga.Cijena * numOfDays;
                        }
                    }
                }
            }
            Stavke.Add(new StavkaFakture
            {
                Naziv = "Međuvrijednost",
                Cijena = Total / 1.17
            });
            Stavke.Add(new StavkaFakture
            {
                Naziv = "Porez (17%)",
                Cijena = Math.Round(Total - Total / 1.17, 2)
            });
            Stavke.Add(new StavkaFakture
            {
                Naziv = "Ukupna cijena",
                Cijena = Total
            });
            Stavke.Add(new StavkaFakture
            {
                Naziv = "Naknada za otkazivanje (40%)",
                Cijena = Total*0.4
            });
            Stavke.Add(new StavkaFakture
            {
                Naziv = "Povrat",
                Cijena = Total - (Total * 0.4)
            });

        }

        private INavigation navigation;
        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }
        public ICommand OtkaziteCommand { get; set; }

        public ObservableCollection<StavkaFakture> Stavke { get; set; } = new ObservableCollection<StavkaFakture>();
        public int _rezervacijaId { get; set; }

        private Model.Rezervacija _rezervacija;

        public Model.Rezervacija Rezervacija
        {
            get { return _rezervacija; }
            set { SetProperty(ref _rezervacija, value); }
        }

    }
}
