using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using xamFormsApp.Models;

namespace xamFormsApp.Core
{
    public class VenueLogic
    {
        public async Task<List<Venue>> GetVenue(double latitue, double longitude)
        {
            List<Venue> venues = new List<Venue>();
            using(HttpClient client =  new HttpClient())
            {
                var response = await client.GetAsync(Venue.GenerateURL(latitue,longitude));
                var json = await response.Content.ReadAsStringAsync();
            }
            return venues;
        }
    }
}
