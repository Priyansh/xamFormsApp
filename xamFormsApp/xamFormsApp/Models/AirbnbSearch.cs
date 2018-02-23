using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xamFormsApp
{
    public class AirbnbSearch
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string formattedDate {
            get
            {
                return string.Format("{0} - {1}", CheckIn.ToString("MMM dd, yyyy"), CheckOut.ToString("MMM dd, yyyy"));
            }
         }
    }
}
