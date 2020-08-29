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
    public class RegistracijaViewModel : BaseViewModel
    {

        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        private readonly APIService _serviceDrzave = new APIService("Drzave");
        private readonly APIService _serviceGradovi = new APIService("Gradovi");
        public RegistracijaViewModel()
        {
            SpremiteCommand = new Command(async () => await Spremite());
            BackToLoginCommand = new Command( () => BackToLogin());
            Title = "Registracija";

        }

        private void BackToLogin()
        {
            Application.Current.MainPage = new LoginPage();

        }

        private async Task Spremite()
        {
            if (OdabraniGrad is null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste odabrali grad!", "OK");
                return;
            }
            Request.UlogaIme = "Klijent";
            Request.GradId = OdabraniGrad.GradId;

            var entity = await _serviceKorisnici.Insert<Model.Korisnik>(Request, "register");

            if (entity != null)
            {

                await Application.Current.MainPage.DisplayAlert("", "Uspješno ste se registrovali!", "OK");
                APIService.Username = Request.Email;
                APIService.Password = Request.Password;
                APIService.PrijavljeniKorisnik = await _serviceKorisnici.Get<Model.Korisnik>(null, "currentUser");

                Application.Current.MainPage = new MainPage();
            }
        }

        public async Task Init()
        {
            Request = new Model.Requests.KorisniciRegistracijaRequest();
         
            var listDrzave = await _serviceDrzave.Get<List<Model.Drzava>>(null);
            DrzaveList.Clear();
            foreach (var drzava in listDrzave)
            {
                DrzaveList.Add(drzava);
            }

        }
        private Model.Requests.KorisniciRegistracijaRequest _request;

        public Model.Requests.KorisniciRegistracijaRequest Request
        {
            get { return _request; }
            set { SetProperty(ref _request, value); }
        }
        public ObservableCollection<Model.Drzava> DrzaveList { get; set; } = new ObservableCollection<Model.Drzava>();
        public ObservableCollection<Model.Grad> GradoviList { get; set; } = new ObservableCollection<Model.Grad>();

        public ICommand SpremiteCommand { get; set; }
        public ICommand BackToLoginCommand { get; set; }
        private Model.Drzava _odabranaDrzava;

        public Model.Drzava OdabranaDrzava
        {
            get { return _odabranaDrzava; }
            set { SetProperty(ref _odabranaDrzava, value); }
        }
        private Model.Grad _odabraniGrad;

        public Model.Grad OdabraniGrad
        {
            get { return _odabraniGrad; }
            set { SetProperty(ref _odabraniGrad, value); }
        }


        internal async Task UpdateCities()
        {
            if (OdabranaDrzava != null)
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
                }
            }
        }


    }
}
