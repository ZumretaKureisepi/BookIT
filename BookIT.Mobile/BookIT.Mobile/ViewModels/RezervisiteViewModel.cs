using BookIT.Mobile.Models;
using BookIT.Mobile.Views;
using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class RezervisiteViewModel
    {
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        private readonly APIService _serviceSobeRezervacije = new APIService("SobeRezervacije");
        private readonly APIService _serviceDodatneUslugeRezervacije = new APIService("DodatneUslugeRezervacije");
        public RezervisiteViewModel(Model.Requests.SmjestajiClientSearchRequest request, int _smjestajId, INavigation _navigation, List<SobaMobile> _listSobe = null, List<DodatnaUslugaSwitchCellItem> _listDodatneUsluge = null)
        {
            Navigation = _navigation;
            SmjestajId = _smjestajId;
            Request = request;
            ListSobe = _listSobe;
            ListDodatneUsluge = _listDodatneUsluge;
            SpremiRezervacijuCommand = new Command(async () => await SpremiRezervaciju());
            SpremiRezervacijuCommand.Execute(null);
            NavigateToMainPageCommand = new Command(() => NavigateToMainPage());

        }

        private void NavigateToMainPage()
        {
            Application.Current.MainPage = new MainPage();
        }

        private async Task SpremiRezervaciju()
        {
            Model.Requests.RezervacijeInsertRequest RezervacijaRequest = new RezervacijeInsertRequest
            {
                BrojGostiju = Request.Djeca + Request.Odrasli,
                CheckInDate = Request.CheckInDate,
                CheckOutDate = Request.CheckOutDate,
                DatumRezervacije = DateTime.Now,
                SmjestajId = SmjestajId,

            };
            var entity = await _serviceRezervacije.Insert<Model.Rezervacija>(RezervacijaRequest);
            if (entity != null)
            {
                if (ListSobe != null)
                {
                    foreach (var soba in ListSobe)
                    {
                        SobeRezervacijeInsertRequest sobeRequest = new SobeRezervacijeInsertRequest
                        {
                            RezervacijaId = entity.RezervacijaId,
                            SobaId = soba.SobaId
                        };
                        await _serviceSobeRezervacije.Insert<Model.SobaRezervacija>(sobeRequest);
                        foreach (var usluga in soba.ListDodatneUsluge)
                        {
                            if (usluga.Checked == true)
                            {
                                DodatneUslugeRezervacijeInsertRequest UslugaRequest = new DodatneUslugeRezervacijeInsertRequest
                                {
                                    DodatnaUslugaId = usluga.DodatnaUslugaId,
                                    RezervacijaId = entity.RezervacijaId,
                                    SobaId = soba.SobaId
                                };
                                await _serviceDodatneUslugeRezervacije.Insert<Model.DodatnaUslugaRezervacija>(UslugaRequest);
                            }
                        }

                    }

                }
                if (ListDodatneUsluge != null)
                {
                    foreach (var usluga in ListDodatneUsluge)
                    {
                        DodatneUslugeRezervacijeInsertRequest UslugaRequest = new DodatneUslugeRezervacijeInsertRequest
                        {
                            DodatnaUslugaId = usluga.DodatnaUslugaId,
                            RezervacijaId = entity.RezervacijaId,
                        };
                        await _serviceDodatneUslugeRezervacije.Insert<Model.DodatnaUslugaRezervacija>(UslugaRequest);

                    }
                }

            }

        }

        private INavigation navigation;
        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }
        public List<SobaMobile> ListSobe { get; set; }
        public List<Models.DodatnaUslugaSwitchCellItem> ListDodatneUsluge { get; set; }
        public SmjestajiClientSearchRequest Request { get; set; }
        public int SmjestajId { get; set; }
        public ICommand SpremiRezervacijuCommand { get; set; }
        public ICommand NavigateToMainPageCommand { get; set; }








    }
}
