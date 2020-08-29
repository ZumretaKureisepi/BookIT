﻿using BookIT.Mobile.ViewModels;
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
	public partial class FaktureListaPage : ContentPage
	{
        private FaktureListaViewModel model;

        public FaktureListaPage ()
		{
			InitializeComponent ();
            BindingContext = model = new FaktureListaViewModel(this.Navigation);

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
    }
}