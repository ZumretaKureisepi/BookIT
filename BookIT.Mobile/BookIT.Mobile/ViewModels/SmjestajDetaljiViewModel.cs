using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BookIT.Mobile.Models;
using BookIT.Mobile.Views;
using BookIT.Model.Requests;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class SmjestajDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _smjestajiService = new APIService("Smjestaji");
        private readonly APIService _sobeService = new APIService("Sobe");
        private readonly APIService _serviceDodatneUslugeSmjestaji = new APIService("DodatneUslugeSmjestaji");
        private readonly APIService _serviceSmjestajiSlike = new APIService("SmjestajiSlike");



        private INavigation navigation;
        private readonly WebView webView;

        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }

        private int _dodatneUslugeListHeight;

        public int DodatneUslugeListHeight
        {
            get { return _dodatneUslugeListHeight; }
            set { SetProperty(ref _dodatneUslugeListHeight, value); }
        }

        public ObservableCollection<Model.SmjestajSlika> SlikeList { get; set; } = new ObservableCollection<Model.SmjestajSlika>();

        public int TrenutnaSlika { get; set; } = 0;

        private byte[] _prikazanaSlika;

        public byte[] PrikazanaSlika
        {
            get { return _prikazanaSlika; }
            set { SetProperty(ref _prikazanaSlika, value); }
        }

        public SmjestajDetaljiViewModel(Model.Requests.SmjestajiClientSearchRequest request, int smjestajId, INavigation _navigation, WebView webView)
        {
            Title = "Rezervacija smještaja";
            navigation = _navigation;
            this.webView = webView;
            Request = request;
            SmjestajId = smjestajId;
            NavigateCommand = new Command(async () => await Navigate());
        }

        private async Task Navigate()
        {
            switch (Smjestaj.TipSmjestaja)
            {
                case Model.TipSmjestaja.Apartman:
                case Model.TipSmjestaja.Vila:
                case Model.TipSmjestaja.Kuca:
                    foreach (var usluga in CollectionDodatneUsluge)
                    {
                        if (usluga.Checked)
                            ListDodatneUsluge.Add(usluga);

                    }
                    await Navigation.PushAsync(new RezervisitePage(Request, SmjestajId, null, ListDodatneUsluge));
                    break;

                case Model.TipSmjestaja.Hotel:
                case Model.TipSmjestaja.Hostel:
                case Model.TipSmjestaja.Motel:
                    await Navigation.PushAsync(new RezervacijaOdaberiSobuPage(Request, SmjestajId));
                    break;
                default:
                    break;
            }

        }
        private async Task UpdateZvjezdica()
        {
            FinalnaOcjena = await _smjestajiService.GetById<double>(SmjestajId, "GetFinalnaOcjena");
            FinalnaOcjenaStr = FinalnaOcjena.ToString($"0.0");

            Zvjezdica1 = Zvjezdica2 = Zvjezdica3 = Zvjezdica4 = Zvjezdica5 = "star_empty.png";

            if (FinalnaOcjena >= 1)
                Zvjezdica1 = "star_filled.png";

            if (FinalnaOcjena >= 1.5 && FinalnaOcjena < 2)
                Zvjezdica2 = "star_half.png";
            else if (FinalnaOcjena >= 2)
                Zvjezdica2 = "star_filled.png";

            if (FinalnaOcjena >= 2.5 && FinalnaOcjena < 3)
                Zvjezdica3 = "star_half.png";
            else if (FinalnaOcjena >= 3)
                Zvjezdica3 = "star_filled.png";

            if (FinalnaOcjena >= 3.5 && FinalnaOcjena < 4)
                Zvjezdica4 = "star_half.png";
            else if (FinalnaOcjena >= 4)
                Zvjezdica4 = "star_filled.png";

            if (FinalnaOcjena >= 4.5 && FinalnaOcjena < 5)
                Zvjezdica5 = "star_half.png";
            else if (FinalnaOcjena == 5)
                Zvjezdica5 = "star_filled.png";

        }

        public async Task Init()
        {
            var smjestaj = await _smjestajiService.GetById<Model.Smjestaj>(SmjestajId);

            var request = new SobeSearchRequest
            {
                SmjestajId = SmjestajId
            };
            var listSobe = await _sobeService.Get<List<Model.Soba>>(request);


            BrojDana = (int)(Math.Ceiling((Request.CheckOutDate - Request.CheckInDate).TotalDays));

            if (BrojDana == 1)
                StrNoci = "noć";
            else
                StrNoci = "noći";

            Smjestaj = smjestaj;

            switch (Smjestaj.TipSmjestaja)
            {
                case Model.TipSmjestaja.Apartman:
                case Model.TipSmjestaja.Vila:
                case Model.TipSmjestaja.Kuca:
                    ButtonTxt = "Rezerviši";
                    IsApartman = true;
                    break;

                case Model.TipSmjestaja.Hotel:
                case Model.TipSmjestaja.Hostel:
                case Model.TipSmjestaja.Motel:
                    ButtonTxt = "Odaberi sobu";
                    break;
                default:
                    break;
            }

            // racunanje cijene
            if (IsApartman)
            {
                Cijena = smjestaj.Cijena.Value;
            }
            else
            {
                foreach (var item in listSobe)
                {
                    if (item.Cijena < Cijena || Cijena == 0)
                        Cijena = item.Cijena;
                }
            }

            Cijena *= BrojDana;

            Porez = Cijena - Cijena / 1.17;

            if (IsApartman)
            {
                var requestUsluga = new Model.Requests.DodatneUslugeSmjestajiSearchRequest
                {
                    SmjestajId = SmjestajId
                };
                var ListUsluge = await _serviceDodatneUslugeSmjestaji.Get<List<Model.DodatnaUslugaSmjestaj>>(requestUsluga);

                CollectionDodatneUsluge.Clear();
                DodatneUslugeListHeight = ListUsluge.Count * 33;
                foreach (var usluga in ListUsluge)
                {
                    CollectionDodatneUsluge.Add(new Models.DodatnaUslugaSwitchCellItem
                    {
                        DodatnaUslugaId = usluga.DodatnaUsluga.DodatnaUslugaId,
                        Naziv = usluga.DodatnaUsluga.Naziv + " (" + usluga.Cijena.ToString("0.00") + " KM po danu)"
                    }); ;
                }
            }

            await UpdateZvjezdica();

            var slike = await _serviceSmjestajiSlike.Get<List<Model.SmjestajSlika>>(request);
            SlikeList.Clear();
            foreach (var slika in slike)
            {
                SlikeList.Add(slika);
            }

            if (SlikeList.Count > 0)
            {
                PrikazanaSlika = SlikeList[0].Slika;
            }

            for (int i = 0; i < 5; i++)
            {
                LoadGoogleMap(smjestaj);
            }

        }

        public void LoadGoogleMap(Model.Smjestaj obj)
        {
            var htmlSource = new HtmlWebViewSource();

            string html = File.ReadAllText("map.html");
            html = html.Replace("{LAT}", obj.Latitude.ToString().Replace(",", "."))
                       .Replace("{LNG}", obj.Longitude.ToString().Replace(",", "."))
                       .Replace("{LOCATIONNAME}", obj.Naziv);

            htmlSource.Html = html;
            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            webView.Source = htmlSource;
        }

        public ICommand InitCommand { get; set; }
        public ICommand NavigateCommand { get; set; }

        public SmjestajiClientSearchRequest Request { get; set; }
        public int SmjestajId { get; set; }
        public ObservableCollection<Models.DodatnaUslugaSwitchCellItem> CollectionDodatneUsluge { get; set; } = new ObservableCollection<Models.DodatnaUslugaSwitchCellItem>();

        public List<DodatnaUslugaSwitchCellItem> ListDodatneUsluge { get; set; } = new List<DodatnaUslugaSwitchCellItem>();

        private bool _isApartman;

        public bool IsApartman
        {
            get { return _isApartman; }
            set { SetProperty(ref _isApartman, value); }
        }



        private Model.Smjestaj _smjestaj;

        public Model.Smjestaj Smjestaj
        {
            get { return _smjestaj; }
            set { SetProperty(ref _smjestaj, value); }
        }

        private int _brojDana;

        public int BrojDana
        {
            get { return _brojDana; }
            set { SetProperty(ref _brojDana, value); }
        }

        private string _strNoci;

        public string StrNoci
        {
            get { return _strNoci; }
            set { SetProperty(ref _strNoci, value); }
        }

        private double _cijena;

        public double Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); CijenaText = "Već od " + value.ToString("0.00") + " KM "; }
        }

        private string _cijenaText;

        public string CijenaText
        {
            get { return _cijenaText; }
            set { SetProperty(ref _cijenaText, value); }
        }


        private double _porez;

        public double Porez
        {
            get { return _porez; }
            set { SetProperty(ref _porez, value); PorezText = "(uključuje " + value.ToString("0.00") + " KM poreza)"; }
        }


        private string _porezText;

        public string PorezText
        {
            get { return _porezText; }
            set { SetProperty(ref _porezText, value); }
        }


        private string _buttonTxt;

        public string ButtonTxt
        {
            get { return _buttonTxt; }
            set { SetProperty(ref _buttonTxt, value); }
        }

        private string _zvjezdica1;

        public string Zvjezdica1
        {
            get { return _zvjezdica1; }
            set { SetProperty(ref _zvjezdica1, value); }
        }

        private string _zvjezdica2;

        public string Zvjezdica2
        {
            get { return _zvjezdica2; }
            set { SetProperty(ref _zvjezdica2, value); }
        }

        private string _zvjezdica3;

        public string Zvjezdica3
        {
            get { return _zvjezdica3; }
            set { SetProperty(ref _zvjezdica3, value); }
        }

        private string _zvjezdica4;

        public string Zvjezdica4
        {
            get { return _zvjezdica4; }
            set { SetProperty(ref _zvjezdica4, value); }
        }

        private string _zvjezdica5;

        public string Zvjezdica5
        {
            get { return _zvjezdica5; }
            set { SetProperty(ref _zvjezdica5, value); }
        }

        private double _finalnaOcjena;

        public double FinalnaOcjena
        {
            get { return _finalnaOcjena; }
            set { SetProperty(ref _finalnaOcjena, value); }
        }
        private string _finalnaOcjenaStr;

        public string FinalnaOcjenaStr
        {
            get { return _finalnaOcjenaStr; }
            set { SetProperty(ref _finalnaOcjenaStr, value); }
        }






    }
}
