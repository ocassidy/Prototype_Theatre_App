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
	public partial class AdventureListView : ContentPage
	{
		public AdventureListView ()
		{
			InitializeComponent ();
		}
        private void TapGestureRecognizer_JumanjiTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Jumanji());
        }
    }
}