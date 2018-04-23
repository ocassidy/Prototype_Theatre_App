using System;
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

        private void ComedyBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void HorrorBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ActionBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void RomanceBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ThrillerBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AdventureBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ScifiBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AnimationBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void DramaBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void FamilyBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void DocumentaryBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_AboutTapped(object sender, EventArgs e)
        {
            DisplayAlert("About", "Created For IID Assignment 2 :)","Ok");
        }
    }
}