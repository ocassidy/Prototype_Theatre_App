﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookingSystem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerificationPage : ContentPage
	{
		public VerificationPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}