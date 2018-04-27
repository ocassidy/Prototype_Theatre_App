using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup;

namespace BookingSystem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TicketPage : ContentPage
    {
        public TicketPage()
        {
            InitializeComponent();
            PaymentPickerAdult.Items.Add("1");
            PaymentPickerAdult.Items.Add("2");
            PaymentPickerAdult.Items.Add("3");
            PaymentPickerAdult.Items.Add("4");
            PaymentPickerAdult.Items.Add("5");


            PaymentPickerChild.Items.Add("1");
            PaymentPickerChild.Items.Add("2");
            PaymentPickerChild.Items.Add("3");
            PaymentPickerChild.Items.Add("4");
            PaymentPickerChild.Items.Add("5");

            PaymentPickerTeen.Items.Add("1");
            PaymentPickerTeen.Items.Add("2");
            PaymentPickerTeen.Items.Add("3");
            PaymentPickerTeen.Items.Add("4");
            PaymentPickerTeen.Items.Add("5");

            PaymentPickerStudent.Items.Add("1");
            PaymentPickerStudent.Items.Add("2");
            PaymentPickerStudent.Items.Add("3");
            PaymentPickerStudent.Items.Add("4");
            PaymentPickerStudent.Items.Add("5");

  
        }

        private async void ContineBtn_Clicked(object sender, EventArgs e)
        {
            var confirm = await DisplayAlert("Continue", "Are you sure you want to continue?", "Ok", "Cancel");

            if(confirm)
            {
                await Navigation.PushAsync(new VerificationPage());
            }
        }

        private void CheckBtn_Clicked(object sender, EventArgs e)
        {
            CheckAdult();
            CheckChild();
            CheckTeen();
            CheckStudent();
        }
        private void CheckAdult()
        {
            if (PaymentPickerAdult.Items.Contains("1"))
            {
                AdultCalc.Text = (5 * 1).ToString();
            }
            else if (PaymentPickerAdult.Items.Contains("2"))
            {
                AdultCalc.Text = (5 * 2).ToString();
            }
            else if (PaymentPickerAdult.Items.Contains("3"))
            {
                AdultCalc.Text = (5 * 3).ToString();
            }
            else if (PaymentPickerAdult.Items.Contains("4"))
            {
                AdultCalc.Text = (5 * 4).ToString();
            }
            else if (PaymentPickerAdult.Items.Contains("5"))
            {
                AdultCalc.Text = (5 * 5).ToString();
            }
        }
        private void CheckChild()
        {
            if(PaymentPickerChild.Items.Contains("1"))
            {
                AdultCalc.Text = (5 * 1).ToString();
            }
            else if(PaymentPickerChild.Items.Contains("2"))
            {
                AdultCalc.Text = (5 * 2).ToString();
            }
            else if(PaymentPickerChild.Items.Contains("3"))
            {
                AdultCalc.Text = (5 * 3).ToString();
            }
            else if(PaymentPickerAdult.Items.Contains("4"))
            {
                AdultCalc.Text = (5 * 4).ToString();
            }
            else if(PaymentPickerAdult.Items.Contains("5"))
            {
                AdultCalc.Text = (5 * 5).ToString();
            }
        }
        private void CheckTeen()
        {
            if (PaymentPickerTeen.Items.Contains("1"))
            {
                AdultCalc.Text = (5 * 1).ToString();
            }
            else if(PaymentPickerTeen.Items.Contains("2"))
            {
                AdultCalc.Text = (5 * 2).ToString();
            }
            else if(PaymentPickerTeen.Items.Contains("3"))
            {
                AdultCalc.Text = (5 * 3).ToString();
            }
            else if(PaymentPickerTeen.Items.Contains("4"))
            {
                AdultCalc.Text = (5 * 4).ToString();
            }
            else if(PaymentPickerTeen.Items.Contains("5"))
            {
                AdultCalc.Text = (5 * 5).ToString();
            }
        }
        private void CheckStudent()
        {
            if(PaymentPickerStudent.Items.Contains("1"))
            {
                AdultCalc.Text = (5 * 1).ToString();
            }
            else if(PaymentPickerStudent.Items.Contains("2"))
            {
                AdultCalc.Text = (5 * 2).ToString();
            }
            else if  (PaymentPickerStudent.Items.Contains("3"))
            {
                AdultCalc.Text = (5 * 3).ToString();
            }
            else if(PaymentPickerTeen.Items.Contains("4"))
            {
                AdultCalc.Text = (5 * 4).ToString();
            }
            else if(PaymentPickerStudent.Items.Contains("5"))
            {
                AdultCalc.Text = (5 * 5).ToString();
            }
        }
    }
}