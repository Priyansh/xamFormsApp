using System;
using System.Collections.Generic;
using Xamarin.Forms;
using xamFormsApp.Core;

namespace xamFormsApp
{
    public partial class RestAPIPage : ContentPage
    {
        public RestAPIPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var venueLogic = new VenueLogic();
            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync();
            venueLogic.GetVenue();
        }
    }
}
