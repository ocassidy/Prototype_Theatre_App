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
	public partial class DocumentaryListView : ContentPage
	{
		public DocumentaryListView ()
		{
			InitializeComponent ();
		}
        private void TapGestureRecognizer_ThreeIdenticalStrangersTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThreeIdenticalStrangers());
        }
        private void TapGestureRecognizer_SeeingAllRedTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SeeingAllRed());
        }
    }
}