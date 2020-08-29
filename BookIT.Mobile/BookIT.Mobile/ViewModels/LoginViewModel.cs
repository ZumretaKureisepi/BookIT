using BookIT.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await IzvrsiLogin());
            RegisterCommand = new Command( () =>  Register());
            Title = "Prijava";
            
        }

        private void Register()
        {
            Application.Current.MainPage = new RegistracijaPage();
        }

        private async Task IzvrsiLogin()
        {
            IsBusy = true;
            APIService.Username = Email;
            APIService.Password = Password;
            try
            {
                APIService.PrijavljeniKorisnik = await _service.Get<Model.Korisnik>(null, "currentUser");
                if (APIService.PrijavljeniKorisnik.Uloga.Naziv == "Klijent")
                    //await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
                    Application.Current.MainPage = new MainPage();
                else
                    await Application.Current.MainPage.DisplayAlert("Greška!", "Pristup ovoj aplikaciji je omogućen samo klijentima!", "Zatvori");
            }
            catch (Exception) { }
            IsBusy = false;


        }

        private string _email=string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email,value); }
        }

        private string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
    }
}
