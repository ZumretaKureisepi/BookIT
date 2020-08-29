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
	public partial class RezervacijeListaPage : ContentPage
	{
        private RezervacijeListaViewModel model;

        public RezervacijeListaPage ()
		{
			InitializeComponent ();
            BindingContext=model = new RezervacijeListaViewModel(this.Navigation);

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

    }
}