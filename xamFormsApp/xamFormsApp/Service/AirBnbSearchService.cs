using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xamFormsApp
{
    public class AirBnbSearchService
    {
        private List<AirbnbSearch> _lstAirBnb = new List<AirbnbSearch>
        {
            new AirbnbSearch { Id = 1, Location = "223-289 Kenwood Ave Burlington, ON L7L 4L9", CheckIn = new DateTime(2016,05,10), CheckOut = new DateTime(2016,08,12) },
            new AirbnbSearch { Id = 2, Location = "67 Dogwood crt, Geogegtown, ON M8B 6P9", CheckIn = new DateTime(2012,02,15), CheckOut = new DateTime(2013,06,28) }
        };
        public IEnumerable<AirbnbSearch> GetSearches(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter))
                return _lstAirBnb;
            else
                return _lstAirBnb.Where(a => a.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
