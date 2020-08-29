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
	public partial class MojProfilPage : ContentPage
	{
        private MojProfilViewModel model;

        public MojProfilPage ()
		{
			InitializeComponent ();
            BindingContext = model = new MojProfilViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            await model.UpdateCities();

        }
    }
}