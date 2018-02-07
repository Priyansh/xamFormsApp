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
    public partial class ListGroupPage : ContentPage
    {
        public ListGroupPage()
        {
            InitializeComponent();
            var GroupItems = new List<ContactGroup>
            {
                new ContactGroup("M", "M")
                {
                    new Contacts { Name = "Mike Tyson", Details = "Do you Wanna Fight"}
                },
                new ContactGroup("K", "K")
                {
                    new Contacts { Name = "Kevin Pillar", Details = "Amazing Athletic"}
                }
            };
            lstViewGroupItems.ItemsSource = GroupItems;
        }

        private void lstViewGroupItems_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var contacts = e.SelectedItem as Contacts;
            //DisplayAlert("ItemSelected", contacts.Name, "OK");
            lstViewGroupItems.SelectedItem = null;
        }

        private void lstViewGroupItems_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contacts = e.Item as Contacts;
            DisplayAlert("ItemTapped", contacts.Name, "OK");
        }
    }
}