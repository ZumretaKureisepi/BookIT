using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class MojProfilViewModel:BaseViewModel
    {
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        private readonly APIService _serviceDrzave = new APIService("Drzave");
        private readonly APIService _serviceGradovi = new APIService("Gradovi");
        public MojProfilViewModel()
        {
            SpremiteCommand = new Command(async () => await Spremite());


        }

        private async Task Spremite()
        {
            if (OdabraniGrad is null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste odabrali grad!", "OK");
                return;
            }
            Request.GradId = OdabraniGrad.GradId;
            var entity = await _serviceKorisnici.Update<Model.Korisnik>(APIService.PrijavljeniKorisnik.KorisnikId, Request);
            if (entity != null) {
                APIService.Username = Request.Email;
                if(!string.IsNullOrWhiteSpace(Request.Password))
                {
                    APIService.Password = Request.Password;
                }
                await Application.Current.MainPage.DisplayAlert("", "Uspješno ste promijenili podatke o korisniku!", "OK");
            }
        }

        public async Task Init()
        {
            var korisnik = await _serviceKorisnici.Get<Model.Korisnik>(null, "currentUser");
            Request = new Model.Requests.KorisniciUpdateRequest
            {
                Ime = korisnik.Ime,
                Prezime = korisnik.Prezime,
                Email = korisnik.Email,
                Adresa = korisnik.Adresa,
                BrojMobitela = korisnik.BrojMobitela,
                GradId = korisnik.GradId
            };
            var listDrzave = await _serviceDrzave.Get<List<Model.Drzava>>(null);
            DrzaveList.Clear();
            foreach (var drzava in listDrzave)
            {
                DrzaveList.Add(drzava);
                if (drzava.DrzavaId == korisnik.Grad.Drzava.DrzavaId)
                    OdabranaDrzava = drzava;
            }

            await UpdateCities();
        }
        private Model.Requests.KorisniciUpdateRequest _request;

        public Model.Requests.KorisniciUpdateRequest Request
        {
            get { return _request; }
            set { SetProperty(ref _request, value); }
        }
        public ObservableCollection<Model.Drzava> DrzaveList { get; set; } = new ObservableCollection<Model.Drzava>();
        public ObservableCollection<Model.Grad> GradoviList { get; set; } = new ObservableCollection<Model.Grad>();

        public ICommand SpremiteCommand { get; set; }
        private Model.Drzava _odabranaDrzava;

        public Model.Drzava OdabranaDrzava
        {
            get { return _odabranaDrzava; }
            set { SetProperty(ref _odabranaDrzava,value); }
        }
        private Model.Grad _odabraniGrad;

        public Model.Grad OdabraniGrad
        {
            get { return _odabraniGrad; }
            set { SetProperty(ref _odabraniGrad, value); }
        }


        internal async Task UpdateCities()
        {
            if(OdabranaDrzava != null)
            {
                var request = new Model.Requests.GradoviSearchRequest
                {
                    DrzavaId = OdabranaDrzava.DrzavaId
                };
                var listGradovi = await _serviceGradovi.Get<List<Model.Grad>>(request);
                GradoviList.Clear();
                foreach (var grad in listGradovi)
                {
                    GradoviList.Add(grad);
                    if (grad.GradId == Request.GradId)
                        OdabraniGrad = grad;
                }
            }
        }
    }
}
