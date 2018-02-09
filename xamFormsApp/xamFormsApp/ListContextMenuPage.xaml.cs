using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamFormsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListContextMenuPage : ContentPage
    {
        private ObservableCollection<Contacts> _contact;
        public ListContextMenuPage()
        {
            InitializeComponent();
            /*_contact = new ObservableCollection<Contacts>
            {
                new Contacts{Name = "Priyansh", Details= "Frendel Kitchens Ltd"},
                new Contacts{Name = "Kupu Shah", Details= "Pharmacetical Ltd"}
            };
            lstViewElement.ItemsSource = _contact;*/
            lstViewElement.ItemsSource = getContacts("");
        }

        private ObservableCollection<Contacts> getContacts(string strVal)
        {
            _contact = new ObservableCollection<Contacts>
            {
                new Contacts{Name = "Priyansh", Details= "Frendel Kitchens Ltd"},
                new Contacts{Name = "Kupu Shah", Details= "Pharmacetical Ltd"}
            };
            if (string.IsNullOrWhiteSpace(strVal))
                return _contact;
            else
            {
                _contact.Where(c => c.Name.StartsWith(strVal));
                return _contact;
            }
        }
        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contacts = menuItem.CommandParameter as Contacts;
            DisplayAlert("Call Clicked", contacts.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contacts = (sender as MenuItem).CommandParameter as Contacts;
            DisplayAlert("Delete Clicked", contacts.Name, "OK");
            _contact.Remove(contacts);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var lstContactFilter = getContacts(e.NewTextValue);
            lstViewElement.ItemsSource = lstContactFilter;
        }
    }
}