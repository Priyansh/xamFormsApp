using System;
using System.Collections.Generic;
using Plugin.Geolocator;
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
            //Get Position of Latitude and Longitude
            var position = await locator.GetPositionAsync();
            locator.PositionChanged += Locator_PositionChanged;
            await locator.StartListeningAsync(TimeSpan.FromSeconds(0), 100);
            //NOTE : REST-API Section Starts here
            var venues = venueLogic.GetVenue(position.Latitude,position.Longitude);
        }

        void Locator_PositionChanged(object sender, Plugin.Geolocator.Abstractions.PositionEventArgs e)
        {
            locationMaps.MapType = Xamarin.Forms.Maps.MapType.Hybrid;
            locationMaps.MoveToRegion(
                new Xamarin.Forms.Maps.MapSpan(new Xamarin.Forms.Maps.Position(e.Position.Latitude, e.Position.Longitude), 2, 2)
            );
        }
    }
}
