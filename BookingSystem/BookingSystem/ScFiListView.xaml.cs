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
	public partial class ScFiListView : ContentPage
	{
		public ScFiListView ()
		{
			InitializeComponent ();
		}
        private void TapGestureRecognizer_SpidermanTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Jumanji());
        }
    }
}