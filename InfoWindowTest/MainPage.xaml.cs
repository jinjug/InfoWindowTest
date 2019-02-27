using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InfoWindowTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            map.Pins.Add(new Xamarin.Forms.GoogleMaps.Pin
            {
                Label= "ATM",
                Address = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum test test test test test test test test test.",
                Position = new Xamarin.Forms.GoogleMaps.Position(0, 0)
            });
        }
    }
}
