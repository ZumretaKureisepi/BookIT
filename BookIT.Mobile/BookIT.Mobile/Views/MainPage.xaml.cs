using BookIT.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookIT.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.PretragaSmjestaja, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.PretragaSmjestaja:
                        MenuPages.Add(id, new NavigationPage(new SmjestajiPage()));
                        break;
                    case (int)MenuItemType.Rezervacija:
                        MenuPages.Add(id, new NavigationPage(new RezervacijeListaPage()));
                        break;
                    case (int)MenuItemType.Faktura:
                        MenuPages.Add(id, new NavigationPage(new FaktureListaPage()));
                        break;
                    case (int)MenuItemType.Profil:
                        MenuPages.Add(id, new NavigationPage(new MojProfilPage()));
                        break;
                    case (int)MenuItemType.Odjava:
                        APIService.PrijavljeniKorisnik = null;
                        APIService.Username = null;
                        APIService.Password = null;

                        Application.Current.MainPage = new LoginPage();
                        return;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}