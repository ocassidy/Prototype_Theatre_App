using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookingSystem.Movies
{
	public partial class SeeingAllRed : ContentPage
	{
		public SeeingAllRed ()
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