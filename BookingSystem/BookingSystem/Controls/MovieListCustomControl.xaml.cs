using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookingSystem.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieListCustomControl : ContentPage
    {
        public MovieListCustomControl()
        {
            InitializeComponent();
        }
    }
}