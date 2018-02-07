using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xamFormsApp
{
    public class ContactGroup : List<Contacts>
    {
        public string Title;
        public string ShortTitle;
        public ContactGroup(string title, string shorttitle)
        {
            this.Title = title;
            this.ShortTitle = shorttitle;
        }
    }
}
