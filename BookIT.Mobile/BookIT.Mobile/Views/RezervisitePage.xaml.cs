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
	public partial class RezervisitePage : ContentPage
	{
		public RezervisitePage (Model.Requests.SmjestajiClientSearchRequest request, int SmjestajId, List<SobaMobile> ListSobe=null, List<Models.DodatnaUslugaSwitchCellItem> ListDodatneUsluge=null)
		{
            BindingContext = new RezervisiteViewModel(request, SmjestajId, this.Navigation, ListSobe, ListDodatneUsluge);
			InitializeComponent ();
		}
	}
}