using BookIT.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class OtkazanaRezervacijaViewModel
    {

        public OtkazanaRezervacijaViewModel()
        {
            NavigateToMainPageCommand = new Command(() => NavigateToMainPage());

        }

        private void NavigateToMainPage()
        {
            Application.Current.MainPage = new MainPage();

        }

        public ICommand NavigateToMainPageCommand { get; set; }




    }
}
