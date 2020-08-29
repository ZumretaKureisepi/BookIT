using BookIT.Mobile.Models;
using BookIT.Mobile.Views;
using BookIT.Model;
using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    class RezervacijeListaViewModel : BaseViewModel
    {
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        private readonly APIService _serviceSmjestajiOcjene = new APIService("SmjestajiOcjene");

        public RezervacijeListaViewModel(INavigation navigation)
        {

            PlatiCommand = new Command<RezervacijaMobile>(async (model) => await Plati(model));
            OtkaziCommand = new Command<RezervacijaMobile>(async (model) => await Otkazi(model));
            OcijeniCommand = new Command<RezervacijaMobile>(async (model) => await Ocijeni(model));
            Navigation = navigation;
            Title = "Moje rezervacije";

        }
        private INavigation navigation;
        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }

        private async Task Plati(RezervacijaMobile model)
        {
            await Navigation.PushAsync(new PotvrdiRezervacijuPage(model.RezervacijaId));
        }

        private async Task Ocijeni(RezervacijaMobile model)
        {
            await Navigation.PushAsync(new RezervacijeOcijeniPage(model.RezervacijaId));
        }

        private async Task Otkazi(RezervacijaMobile model)
        {
            await Navigation.PushAsync(new OtkaziRezervacijuPage(model.RezervacijaId));
        }

        public ObservableCollection<RezervacijaMobile> RezervacijeList { get; set; } = new ObservableCollection<RezervacijaMobile>();

        public ICommand PlatiCommand { get; set; }
        public ICommand OtkaziCommand { get; set; }
        public ICommand OcijeniCommand { get; set; }

        public async Task Init()
        {

            var list = await _serviceRezervacije.Get<List<RezervacijaMobile>>(null);

            RezervacijeList.Clear();

            foreach (var item in list)
            {
                if (item.CheckInDate.Date >= DateTime.Now.Date)
                {
                    if (item.Status == RezervacijaMobile.eStanje.CekanjeUplate)
                        item.MozePlatiti = true;
                    if ((item.Status == RezervacijaMobile.eStanje.CekanjePotvrde || item.Status == RezervacijaMobile.eStanje.CekanjeUplate) && (item.CheckInDate - DateTime.Now).TotalDays > 5)
                        item.MozeOtkazati = true;
                }
                if (DateTime.Now.Date >= item.CheckInDate.Date && item.Status == RezervacijaMobile.eStanje.Finalizirana)
                {
                    var request = new Model.Requests.SmjestajiOcjeneSearchRequest
                    {
                        SmjestajId = item.SmjestajId
                    };
                    var ListOcjene = await _serviceSmjestajiOcjene.Get<List<Model.SmjestajOcjena>>(request, "GetMyReviews");
                    if (ListOcjene.Count == 0)
                        item.MozeOcijeniti = true;
                }
                RezervacijeList.Add(item);
            }

        }









    }
}
