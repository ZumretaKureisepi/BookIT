using BookIT.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookIT.Mobile.Views
{
    public interface IBaseUrl { string Get(); }


    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SmjestajDetaljiPage : ContentPage
	{
        private SmjestajDetaljiViewModel model;

        public bool Transitioning { get; set; }

        public SmjestajDetaljiPage ()
		{
			InitializeComponent ();
		}
        public SmjestajDetaljiPage(Model.Requests.SmjestajiClientSearchRequest request, int SmjestajId)
        {
            InitializeComponent();
            BindingContext = model = new SmjestajDetaljiViewModel(request, SmjestajId, this.Navigation, webView);

        }

		protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            model.LoadGoogleMap(model.Smjestaj);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var element = sender as StackLayout;
            var context = element.BindingContext as Model.SmjestajSlika;

            model.PrikazanaSlika = context.Slika;
            for (int i = 0; i < model.SlikeList.Count; i++)
            {
                if (model.SlikeList[i].SmjestajSlikaId == context.SmjestajSlikaId)
                {
                    model.TrenutnaSlika = i;
                    break;
                }
            }
        }

        private async void SwipeGestureRecognizer_Swiped_Left(object sender, SwipedEventArgs e)
        {
            if (model.TrenutnaSlika < model.SlikeList.Count - 1 && !Transitioning)
            {
                uint transitionTime = 300;
                Transitioning = true;
                double displacement = PrikazanaSlikaImage.Width;

                await Task.WhenAll(
                    PrikazanaSlikaImage.FadeTo(0, transitionTime, Easing.Linear),
                    PrikazanaSlikaImage.TranslateTo(-displacement, PrikazanaSlikaImage.Y, transitionTime, Easing.CubicInOut));

                model.TrenutnaSlika++;
                if (model.TrenutnaSlika >= model.SlikeList.Count)
                    model.TrenutnaSlika = model.SlikeList.Count - 1;

                model.PrikazanaSlika = model.SlikeList[model.TrenutnaSlika].Slika;

                await PrikazanaSlikaImage.TranslateTo(displacement, 0, 0);
                await Task.WhenAll(
                    PrikazanaSlikaImage.FadeTo(1, transitionTime, Easing.Linear),
                    PrikazanaSlikaImage.TranslateTo(0, PrikazanaSlikaImage.Y, transitionTime, Easing.CubicInOut));

                Transitioning = false;

            }
        }

        private async void SwipeGestureRecognizer_Swiped_Right(object sender, SwipedEventArgs e)
        {
            if (model.TrenutnaSlika > 0 && !Transitioning)
            {
                uint transitionTime = 300;
                Transitioning = true;
                double displacement = PrikazanaSlikaImage.Width;

                await Task.WhenAll(
                    PrikazanaSlikaImage.FadeTo(0, transitionTime, Easing.Linear),
                    PrikazanaSlikaImage.TranslateTo(displacement, PrikazanaSlikaImage.Y, transitionTime, Easing.CubicInOut));

                model.TrenutnaSlika--;
                if (model.TrenutnaSlika < 0)
                    model.TrenutnaSlika = 0;

                model.PrikazanaSlika = model.SlikeList[model.TrenutnaSlika].Slika;

                await PrikazanaSlikaImage.TranslateTo(-displacement, 0, 0);
                await Task.WhenAll(
                    PrikazanaSlikaImage.FadeTo(1, transitionTime, Easing.Linear),
                    PrikazanaSlikaImage.TranslateTo(0, PrikazanaSlikaImage.Y, transitionTime, Easing.CubicInOut));

                Transitioning = false;

            }
        }

    }
}