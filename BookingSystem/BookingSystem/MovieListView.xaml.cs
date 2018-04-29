using BookingSystem.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookingSystem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MovieListView : ContentPage
	{
		public MovieListView ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_BlackPantherTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BlackPanther());
        }
        private void TapGestureRecognizer_ReadyPlayerOneTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReadyPlayerOne());
        }
        private void TapGestureRecognizer_AQuietPlaceTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AQuietPlace());
        }
        private void TapGestureRecognizer_StarWarsTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StarWars());
        }
        private void TapGestureRecognizer_AvengersTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AvengersInfinityWar());
        }
        private void TapGestureRecognizer_JumanjiTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Jumanji());
        }
        private void TapGestureRecognizer_IncrediblesTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Incredibles());
        }
        private void TapGestureRecognizer_PeterRabbitTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PeterRabbit());
        }
    }
}