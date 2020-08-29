using BookIT.Mobile.Models;
using BookIT.Mobile.Views;
using BookIT.Model;
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
    public class SmjestajiPretragaRezultatViewModel : BaseViewModel
    {
        private readonly APIService _smjestajiService = new APIService("Smjestaji");
        private readonly APIService _smjestajiSlikeService = new APIService("SmjestajiSlike");
        private readonly APIService _smjestajiOcjeneService = new APIService("SmjestajiOcjene");

        private INavigation navigation;
        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }

        public SmjestajiPretragaRezultatViewModel(Model.Requests.SmjestajiClientSearchRequest request, INavigation _navigation)
        {
            Title = "Ponuda smještaja";
            Request = request;
            navigation = _navigation;
            //Lokacija = request.Lokacija;
            //CheckInDate = request.CheckInDate;
            //CheckOutDate = request.CheckOutDate;
            //Odrasli = request.Odrasli;
            //Djeca = request.Djeca;
            //Sobe = request.Sobe;




            BookCommand = new Command<SmjestajMobile>(async (model) => await Book(model));

            NavigateToViseFilteraCommand = new Command(async () => await NavigateToViseFiltera());
        }

        private async Task Book(SmjestajMobile model)
        {

            await Navigation.PushAsync(new SmjestajDetaljiPage(Request, model.SmjestajId));


        }

        public ObservableCollection<SmjestajMobile> SmjestajiList { get; set; } = new ObservableCollection<SmjestajMobile>();

        public Model.Requests.SmjestajiClientSearchRequest Request { get; set; }

        public ICommand NavigateToViseFilteraCommand { get; set; }
        public ICommand BookCommand { get; set; }

        public async Task Init()
        {

            var list = await _smjestajiService.Get<List<SmjestajMobile>>(Request, "clientGet");

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

        public async Task NavigateToViseFiltera()
        {
            await Navigation.PushAsync(new SmjestajiPretragaPage());
        }

        



    }
}
