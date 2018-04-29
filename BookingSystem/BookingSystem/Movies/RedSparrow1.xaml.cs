using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookingSystem.Movies
{
	public partial class RedSparrow1 : ContentPage
	{
		public RedSparrow1 ()
		{
			InitializeComponent ();
            LocationPick.Items.Add("Derry");
            LocationPick.Items.Add("Coleraine");
            LocationPick.Items.Add("Strabane");
            LocationPick.Items.Add("Limavady");
            LocationPick.SelectedIndex = 0;
        }
        private void TicketBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TicketPage());
        }
    }
}