using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BookIT.Mobile.Views;
using System.Globalization;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BookIT.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            CultureInfo.CurrentCulture = new CultureInfo("bs-BA");


            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
