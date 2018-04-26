using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Movies;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookingSystem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DramaListView : ContentPage
	{
		public DramaListView ()
		{
			InitializeComponent ();
		}
        private void TapGestureRecognizer_RedSparrowTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RedSparrow1());
        }
        private void TapGestureRecognizer_LoveSimonTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoveSimon());
        }
    }
}