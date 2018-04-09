﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BookingSystem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ViewAllBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MovieListView());
        }
    }
}