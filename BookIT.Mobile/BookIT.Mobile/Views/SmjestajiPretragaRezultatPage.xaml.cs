using BookIT.Mobile.Models;
using BookIT.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookIT.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SmjestajiPretragaRezultatPage : ContentPage
    {
        private SmjestajiPretragaRezultatViewModel model;

        public SmjestajiPretragaRezultatPage(Model.Requests.SmjestajiClientSearchRequest request)
        {
            BindingContext=model = new SmjestajiPretragaRezultatViewModel(request, this.Navigation);

            InitializeComponent();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var request = (BindingContext as SmjestajiPretragaRezultatViewModel).Request;

            int smjestajId = (e.Item as SmjestajMobile).SmjestajId;

            await Navigation.PushAsync(new SmjestajDetaljiPage(request, smjestajId));
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
    }
}