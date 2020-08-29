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
	public partial class PotvrdjenaRezervacijaPage : ContentPage
	{
		public PotvrdjenaRezervacijaPage ()
		{
			InitializeComponent ();
            BindingContext = new PotvrdjenaRezervacijaViewModel();
		}
	}
}