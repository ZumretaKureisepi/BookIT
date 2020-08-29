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
	public partial class PotvrdiRezervacijuPage : ContentPage
	{
        private PotvrdiRezervacijuViewModel model;

        public PotvrdiRezervacijuPage (int rezervacijaId)
		{
			InitializeComponent ();
            BindingContext=model = new PotvrdiRezervacijuViewModel(rezervacijaId, this.Navigation);
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
    }
}