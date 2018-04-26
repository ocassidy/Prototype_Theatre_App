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
	public partial class FamilyListView : ContentPage
	{
		public FamilyListView ()
		{
			InitializeComponent ();
		}
        private void TapGestureRecognizer_PeterRabbitTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PeterRabbit());
        }
        private void TapGestureRecognizer_EarlyManTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EarlyMan());
        }
    }
}