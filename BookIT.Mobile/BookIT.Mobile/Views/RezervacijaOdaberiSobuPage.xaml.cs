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
	public partial class RezervacijaOdaberiSobuPage : ContentPage
	{
        private RezervacijaOdaberiSobuViewModel model;

        public RezervacijaOdaberiSobuPage (Model.Requests.SmjestajiClientSearchRequest request, int SmjestajId)
		{
			InitializeComponent ();
            BindingContext=model = new RezervacijaOdaberiSobuViewModel(request, SmjestajId, this.Navigation);
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
    }
}