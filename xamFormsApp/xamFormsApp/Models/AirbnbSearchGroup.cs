using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xamFormsApp
{
    public class AirbnbSearchGroup : ObservableCollection<AirbnbSearch>
    {
        public string Title { get; set; }
        public AirbnbSearchGroup(string Title, IEnumerable<AirbnbSearch> airbnbSearch) : base(airbnbSearch)
        {
            this.Title = Title;
        }
    }
}
