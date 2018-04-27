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
	public partial class EnterDetailsPage : ContentPage
	{
		public EnterDetailsPage ()
		{
			InitializeComponent ();
		}
        private async void ConfirmBtn_Clicked(object sender, EventArgs e)
        {
            var confirm = await DisplayAlert("Continue", "Are you sure you want to continue?", "Ok", "Cancel");

            if (confirm)
            {
                await Navigation.PushAsync(new VerificationPage());
            }
        }
    }
}