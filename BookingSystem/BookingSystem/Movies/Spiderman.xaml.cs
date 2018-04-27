using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookingSystem.Movies
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Spiderman : ContentPage
	{
		public Spiderman ()
		{
			InitializeComponent ();
            LocationPick.Items.Add("Derry");
            LocationPick.Items.Add("Coleraine");
            LocationPick.Items.Add("Strabane");
            LocationPick.Items.Add("Limavady");
        }
        private void TicketBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TicketPage());
        }
    }
}