using BookIT.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class FaktureListaViewModel:BaseViewModel
    {
        private readonly APIService _serviceFakture = new APIService("Fakture");

        public FaktureListaViewModel(INavigation navigation)
        {
            
            Navigation = navigation;
            NavigateToDetaljiCommand = new Command<Model.Faktura>(async (model) => await NavigateToDetalji(model));
            Title = "Moje fakture";


        }

        private async Task NavigateToDetalji(Model.Faktura faktura)
        {
            await Navigation.PushAsync(new FakturaDetaljiPage(faktura.FakturaId));


        }

        private INavigation navigation;
        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }
        

        public ObservableCollection<Model.Faktura> FaktureList { get; set; } = new ObservableCollection<Model.Faktura>();
        

        public async Task Init()
        {

            var list = await _serviceFakture.Get<List<Model.Faktura>>(null);

            FaktureList.Clear();
            int i = 1;
            foreach (var item in list)
            {
                item.RedniBroj = i++;
                FaktureList.Add(item);
            }

        }
        public ICommand NavigateToDetaljiCommand { get; set; }

    }
}
