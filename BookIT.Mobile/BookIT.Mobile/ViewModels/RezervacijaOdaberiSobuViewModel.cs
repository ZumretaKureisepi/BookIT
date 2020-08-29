using BookIT.Mobile.Models;
using BookIT.Mobile.Views;
using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class RezervacijaOdaberiSobuViewModel:BaseViewModel
    {
        private readonly APIService _serviceSobe = new APIService("Sobe");
        private readonly APIService _serviceDodatneUslugeSobe= new APIService("DodatneUslugeSobe");
        private readonly APIService _serviceSobeSlike= new APIService("SobeSlike");



        private INavigation navigation;
        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }

        public RezervacijaOdaberiSobuViewModel(Model.Requests.SmjestajiClientSearchRequest request, int SmjestajId, INavigation _navigation)
        {
            Title = "Odaberite sobu";
            navigation = _navigation;
            Request = request;
            this.SmjestajId = SmjestajId;

            OdaberiSobuCommand = new Command<SobaMobile>( (model) => OdaberiSobu(model));
            

            RezervisiteCommand = new Command( () => Rezervisite());

        }

        private void Rezervisite()
        {
             Application.Current.MainPage= new RezervisitePage(Request,SmjestajId,OdabraneSobeList);
        }

        private void OdaberiSobu(SobaMobile model)
        {
            List<SobaMobile> listSobe = new List<SobaMobile>();
            if (model.Odabrana == false)
            {
                model.Odabrana = true;
                model.OdaberiSobuText = "Uklonite sobu";
                OdabraneSobeList.Add(model);
            }
            else
            {
                model.Odabrana = false;
                model.OdaberiSobuText = "Odaberite sobu";
                for (int i = 0; i < OdabraneSobeList.Count; i++)
                {
                    if (OdabraneSobeList[i].SobaId == model.SobaId)
                    {
                        OdabraneSobeList.RemoveAt(i);
                        break;
                    }

                }
            }
            foreach (var item in SobeList)
            {
                listSobe.Add(item);
            }
            SobeList.Clear();
            foreach (var item in listSobe)
            {
                SobeList.Add(item);

            }

        }

        public async Task Init()
        {
            var request = new SobeSearchRequest
            {
                SmjestajId = SmjestajId
            };
            var listSobe = await _serviceSobe.Get<List<SobaMobile>>(request);
            SobeList.Clear();

            int BrojDana = (int)(Math.Ceiling((Request.CheckOutDate - Request.CheckInDate).TotalDays));

            foreach (var item in listSobe)
            {
                var requestDodatneUsluge = new DodatneUslugeSobeSearchRequest
                {
                    SobaId = item.SobaId
                };

                item.CijenaBoravkaText = (item.Cijena * BrojDana).ToString("0.00") + " KM";


                var listDodatneUslugeSobe = await _serviceDodatneUslugeSobe.Get<List<Model.DodatnaUslugaSoba>>(requestDodatneUsluge);
                foreach (var usluga in listDodatneUslugeSobe)
                {
                    if (item.strDodatneUsluge != null)
                        item.strDodatneUsluge += ", ";

                    item.strDodatneUsluge += usluga.DodatnaUsluga.Naziv;
                    item.ListDodatneUsluge.Add(new DodatnaUslugaSwitchCellItem
                    {
                        Checked = false,
                        DodatnaUslugaId = usluga.DodatnaUsluga.DodatnaUslugaId,
                        Naziv = usluga.DodatnaUsluga.Naziv,
                        Cijena = usluga.Cijena
                    });

                }

              
                var SobaSlika = await _serviceSobeSlike.GetById<Model.SobaSlika>(item.SobaId, "GetSobeSlika");
                if (SobaSlika!=null)
                    item.Slika = SobaSlika.Slika;
                SobeList.Add(item);
            }

        }
        public ObservableCollection<SobaMobile> SobeList { get; set; } = new ObservableCollection<SobaMobile>();
        public List<SobaMobile> OdabraneSobeList { get; set; } = new List<SobaMobile>();

        public SmjestajiClientSearchRequest Request { get; set; }
        public int SmjestajId { get; set; }
        public Command OdaberiSobuCommand { get; private set; }
        public Command RezervisiteCommand { get; private set; }


    }
}
