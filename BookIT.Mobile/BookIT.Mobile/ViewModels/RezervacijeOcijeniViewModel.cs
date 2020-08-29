using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BookIT.Mobile.Models;
using BookIT.Mobile.Views;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class RezervacijeOcijeniViewModel:BaseViewModel
    {
        private readonly APIService _serviceSmjestajiOcjene = new APIService("SmjestajiOcjene");
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        public RezervacijeOcijeniViewModel(int _rezervacijaId, INavigation _navigation)
        {
            RezervacijaId = _rezervacijaId;
            Rate1StarCommand = new Command<Models.OcjenaListItem>(async (model) => await Rate1Star(model));
            Rate2StarCommand = new Command<Models.OcjenaListItem>(async (model) => await Rate2Star(model));
            Rate3StarCommand = new Command<Models.OcjenaListItem>(async (model) => await Rate3Star(model));
            Rate4StarCommand = new Command<Models.OcjenaListItem>(async (model) => await Rate4Star(model));
            Rate5StarCommand = new Command<Models.OcjenaListItem>(async (model) => await Rate5Star(model));
            SpremiOcjenuCommand = new Command(async () => await SpremiOcjenu());
            Navigation = _navigation;
        }

        private async Task SpremiOcjenu()
        {
            var rezervacija = await _serviceRezervacije.GetById<Model.Rezervacija>(RezervacijaId);
            var request = new Model.Requests.SmjestajiOcjeneInsertRequest
            {
                SmjestajId = rezervacija.SmjestajId,


            };
            foreach (var ocjena in OcjeneList)
            {
              
                if (ocjena.VrstaOcjene == "Vlasnik smještaja")
                    request.OcjenaVlasnikSmjestaja = ocjena.Ocjena;
                if (ocjena.VrstaOcjene == "Dodatne usluge")
                    request.OcjenaDodatneUsluge = ocjena.Ocjena;
                if (ocjena.VrstaOcjene == "Isplativost")
                    request.OcjenaIsplativost = ocjena.Ocjena;
                if (ocjena.VrstaOcjene == "Lokacija")
                    request.OcjenaLokacija = ocjena.Ocjena;
                if (ocjena.VrstaOcjene == "Udobnost")
                    request.OcjenaUdobnost = ocjena.Ocjena;
                if (ocjena.VrstaOcjene == "Čistoća")
                    request.OcjenaCistoca = ocjena.Ocjena;

            }
            var entity= await _serviceSmjestajiOcjene.Insert<Model.SmjestajOcjena>(request);
            if (entity != null)
                await Navigation.PushAsync(new RezervacijeListaPage());

        }

        private async Task Rate1Star(OcjenaListItem model)
        {
            model.Ocjena = 1;
            UpdateOcjeneList();

        }
        private async Task Rate2Star(OcjenaListItem model)
        {
            model.Ocjena = 2;
            UpdateOcjeneList();
        }
        private async Task Rate3Star(OcjenaListItem model)
        {
            model.Ocjena = 3;
            UpdateOcjeneList();
        }
        private async Task Rate4Star(OcjenaListItem model)
        {
            model.Ocjena = 4;
            UpdateOcjeneList();
        }
        private async Task Rate5Star(OcjenaListItem model)
        {
            model.Ocjena = 5;
            UpdateOcjeneList();
        }

        private void UpdateOcjeneList()
        {
            List<Models.OcjenaListItem> NewOcjeneList = new List<OcjenaListItem>();

            foreach (var item in OcjeneList)
            {
                NewOcjeneList.Add(item);
            }
            OcjeneList.Clear();
            foreach (var item in NewOcjeneList)
            {
                OcjeneList.Add(item);
            }
        }

        public int RezervacijaId { get; set; }
        public ObservableCollection<Models.OcjenaListItem> OcjeneList { get; set; } = new ObservableCollection<OcjenaListItem>();

        internal async Task Init()
        {
            OcjeneList.Add(new OcjenaListItem {
                VrstaOcjene = "Vlasnik smještaja",
            });
            OcjeneList.Add(new OcjenaListItem {
                VrstaOcjene = "Dodatne usluge",
            });
            OcjeneList.Add(new OcjenaListItem {
                VrstaOcjene = "Isplativost",
            });
            OcjeneList.Add(new OcjenaListItem {
                VrstaOcjene = "Lokacija",
            });
            OcjeneList.Add(new OcjenaListItem {
                VrstaOcjene = "Udobnost",
            });
            OcjeneList.Add(new OcjenaListItem {
                VrstaOcjene = "Čistoća",
            });


            var rezervacija = await _serviceRezervacije.GetById<Model.Rezervacija>(RezervacijaId);
            Title = "Ocjenjivanje smještaja " + rezervacija.Smjestaj.Naziv;
        }
        public ICommand Rate1StarCommand { get; set; }
        public ICommand Rate2StarCommand { get; set; }
        public ICommand Rate3StarCommand { get; set; }
        public ICommand Rate4StarCommand { get; set; }
        public ICommand Rate5StarCommand { get; set; }
        public ICommand SpremiOcjenuCommand { get; set; }

        private INavigation Navigation;
    }
}
