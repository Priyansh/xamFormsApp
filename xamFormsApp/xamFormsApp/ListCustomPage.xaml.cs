using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamFormsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListCustomPage : ContentPage
    {
        public ListCustomPage()
        {
            InitializeComponent();
            var items = new List<Contacts> {
                new Contacts {
                    Name = "Mike Tyson",
                    Details= "Are you ready for fight Mike?",
                    ImageUrls="http://lorempixel.com/200/200/people/1"
                },
                new Contacts {
                    Name = "Kevin Pillar",
                    Details="How's Going Pillar",
                    ImageUrls="http://lorempixel.com/200/200/people/2"
                }
            };
            lstElement.ItemsSource = items;
        }
    }
}