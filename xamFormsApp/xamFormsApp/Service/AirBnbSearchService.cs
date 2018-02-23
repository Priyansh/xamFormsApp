using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xamFormsApp
{
    // User's searches can be stored either in a database on the device, or 
    // somewhere in the cloud. We use SearchService to work with the persistence
    // store for the app. So this class hides the complexity behind accessing
    // the recent searches. Whether they're stored locally or in the cloud, it 
    // doesn't matter from the perspective of the user interface.

    // Note nowhere in this class we're using an ObservableCollection, because 
    // this is a collection type that we often use in Xamarin or WPF apps. 
    // In theory, we should be able to re-use this SearchService in an ASP.NET MVC 
    // web app. We don't have ObservableCollection in web apps. So, this class
    // should not know anything about ObservableCollection. GetRecentSearches method simply returns an
    // IEnumerable. 
    public class AirBnbSearchService
    {
        // Currently I've hardcoded the list of searches here. But they could be
        // stored in a database or fetched via a remote service. 
        private List<AirbnbSearch> _lstAirBnb = new List<AirbnbSearch>
        {
            new AirbnbSearch { Id = 1, Location = "223-289 Kenwood Ave Burlington, ON L7L 4L9", CheckIn = new DateTime(2016, 05, 10), CheckOut = new DateTime(2016, 08, 12) },
            new AirbnbSearch { Id = 2, Location = "67 Dogwood crt, Geogegtown, ON M8B 6P9", CheckIn = new DateTime(2012, 02, 15), CheckOut = new DateTime(2013, 06, 28) },
            new AirbnbSearch { Id = 1, Location = "West Hollywood, CA, United States", CheckIn = new DateTime(2016, 09, 01), CheckOut = new DateTime(2016, 11, 01) },
            new AirbnbSearch { Id = 1, Location = "Santa Monica, CA, United States", CheckIn = new DateTime(2017, 10, 15), CheckOut = new DateTime(2019, 10, 29) }
        };
        public IEnumerable<AirbnbSearch> GetSearches(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter))
                return _lstAirBnb;
            else
                // Note that I've used StringComparison.CurrentCultureIgnoreCase 
                // so searching is case-insensitive.
                return _lstAirBnb.Where(a => a.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }

        public void DeleteSearch(int id)
        {
            _lstAirBnb.Remove(_lstAirBnb.Single(a => a.Id == id));
        }
    }
}
