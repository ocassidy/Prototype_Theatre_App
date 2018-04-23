using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup;
using Rg.Plugins.Popup.Extensions;

namespace BookingSystem
{
    public partial class BlackPanther : ContentPage
    {
        public BlackPanther()
        {
            InitializeComponent();

            LocationPick.Items.Add("Derry-Springtown");
            LocationPick.Items.Add("Derry-Strand Road");
            LocationPick.Items.Add("Coleraine");
            LocationPick.Items.Add("Strabane");

        }
    }
}