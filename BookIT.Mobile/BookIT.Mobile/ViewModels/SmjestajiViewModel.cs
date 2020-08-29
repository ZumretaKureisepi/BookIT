using BookIT.Mobile.Models;
using BookIT.Mobile.Views;
using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class SmjestajiViewModel : BaseViewModel
    {
        private readonly APIService _smjestajiService = new APIService("Smjestaji");
        private readonly APIService _preporukaService = new APIService("Preporuka");
        private readonly APIService _smjestajiSlikeService = new APIService("SmjestajiSlike");
        private readonly APIService _smjestajiOcjeneService = new APIService("SmjestajiOcjene");

        private INavigation navigation;
        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }
        public ObservableCollection<SmjestajMobile> SmjestajiList { get; set; } = new ObservableCollection<SmjestajMobile>();
        public ICommand BookCommand { get; set; }


        public SmjestajiViewModel(INavigation _navigation)
        {
            navigation = _navigation;

            NavigateToPretragaRezultatPageCommand = new Command(async () => await NavigateToPretragaRezultatPage());
            BookCommand = new Command<SmjestajMobile>(async (model) => await Book(model));
            Title = "Pretraga smještaja";

            CheckInDate = DateTime.Now;
            CheckOutDate = DateTime.Now.AddDays(1);

            Odrasli = "1";

        }

        private async Task Book(SmjestajMobile model)
        {
            var Request = await GetSearchRequest();
            if (Request == null)
                return;

            await Navigation.PushAsync(new SmjestajDetaljiPage(Request, model.SmjestajId));
        }
        
        public async Task Init()
        {
            var list = await _preporukaService.Get<List<SmjestajMobile>>(null);

            SmjestajiList.Clear();
            foreach (var smjestaj in list)
            {

                var Slika = await _smjestajiSlikeService.GetById<Model.SmjestajSlika>(smjestaj.SmjestajId, "GetSmjestajSlika");
                if (Slika != null)
                    smjestaj.Slika = Slika.Slika;
                var request = new Model.Requests.SmjestajiOcjeneSearchRequest
                {
                    SmjestajId = smjestaj.SmjestajId
                };
                var ListOcjene = await _smjestajiOcjeneService.Get<List<Model.SmjestajOcjena>>(request);
                double[] OcjeneNiz = new double[6];
                for (int i = 0; i < 6; i++)
                {
                    OcjeneNiz[i] = 0;
                }


                if (ListOcjene.Count > 0)
                {
                    foreach (var ocjena in ListOcjene)
                    {
                        OcjeneNiz[0] += ocjena.OcjenaCistoca;
                        OcjeneNiz[1] += ocjena.OcjenaDodatneUsluge;
                        OcjeneNiz[2] += ocjena.OcjenaIsplativost;
                        OcjeneNiz[3] += ocjena.OcjenaLokacija;
                        OcjeneNiz[4] += ocjena.OcjenaVlasnikSmjestaja;
                        OcjeneNiz[5] += ocjena.OcjenaUdobnost;

                    }
                    for (int i = 0; i < 6; i++)
                    {
                        OcjeneNiz[i] /= ListOcjene.Count;
                    }
                }
                double maxValue = OcjeneNiz.Max();
                int maxIndex = OcjeneNiz.ToList().IndexOf(maxValue);
                if (maxValue >= 4)
                {
                    switch (maxIndex)
                    {
                        case 0: smjestaj.OcjenaOpis = "Izrazito čiste sobe!"; break;
                        case 1: smjestaj.OcjenaOpis = "Funkcionalnost dodatnih usluga je po najvećim standardima!"; break;
                        case 2: smjestaj.OcjenaOpis = "Izvrstan omjer cijene i kvalitete!"; break;
                        case 3: smjestaj.OcjenaOpis = "Smještaj je na izrazito atraktivnoj lokaciji!"; break;
                        case 4: smjestaj.OcjenaOpis = "Vlasnik smještaja je izrazito ljubazan!"; break;
                        case 5: smjestaj.OcjenaOpis = "Udobnost smještaja je na visokom nivou!"; break;

                        default:
                            break;
                    }
                }
                else
                {
                    smjestaj.OcjenaOpis = "Smještaj je neocijenjen!";
                }

                double FinalnaOcjena = await _smjestajiService.GetById<double>(smjestaj.SmjestajId, "GetFinalnaOcjena");
                smjestaj.FinalnaOcjenaStr = FinalnaOcjena.ToString($"0.0");

                SmjestajiList.Add(smjestaj);
            }
        }

        public ICommand NavigateToPretragaRezultatPageCommand { get; set; }

        public async Task NavigateToPretragaRezultatPage()
        {
            var Request = await GetSearchRequest();
            if (Request == null)
                return;

            await Navigation.PushAsync(new SmjestajiPretragaRezultatPage(Request));
        }

        private async Task<SmjestajiClientSearchRequest> GetSearchRequest()
        {
            var request = new Model.Requests.SmjestajiClientSearchRequest
            {
                Lokacija = Lokacija,
                CheckInDate = CheckInDate,
                CheckOutDate = CheckOutDate,
                Djeca = int.TryParse(Djeca, out int val) ? val : 0,
                Odrasli = int.TryParse(Odrasli, out int val1) ? val1 : 0,
                //Sobe = int.TryParse(Sobe, out int val2) ? val2 : 0
            };
            if (request.CheckInDate.Date == request.CheckOutDate.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Datum prijave mora biti različit od datuma odjave!", "OK");
                return null;
            }
            if (request.CheckInDate.Date > request.CheckOutDate.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Datum prijave mora biti prije datuma odjave!", "OK");
                return null;
            }
            if (request.CheckInDate.Date < DateTime.Now.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Datum prijave ne može biti u prošlosti!", "OK");
                return null;
            }
            if (request.Djeca < 0)
                request.Djeca = 0;
            if (request.Odrasli < 0)
                request.Odrasli = 0;
            if (request.Odrasli == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Potrebno je da bude unesena bar jedna odrasla osoba!", "OK");
                return null;
            }

            return request;
        }

        private string _lokacija = string.Empty;

        public string Lokacija
        {
            get { return _lokacija; }
            set { SetProperty(ref _lokacija, value); }
        }

        private DateTime _checkInDate;

        public DateTime CheckInDate
        {
            get { return _checkInDate; }
            set { SetProperty(ref _checkInDate, value); }
        }

        private DateTime _checkOutDate;

        public DateTime CheckOutDate
        {
            get { return _checkOutDate; }
            set { SetProperty(ref _checkOutDate, value); }
        }

        private string _sobe = string.Empty;

        public string Sobe
        {
            get { return _sobe; }
            set { SetProperty(ref _sobe, value); }
        }

        private string _odrasli = string.Empty;

        public string Odrasli
        {
            get { return _odrasli; }
            set { SetProperty(ref _odrasli, value); }
        }

        private string _djeca = string.Empty;

        public string Djeca
        {
            get { return _djeca; }
            set { SetProperty(ref _djeca, value); }
        }


    }
}
