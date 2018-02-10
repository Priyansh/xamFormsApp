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
        //private ObservableCollection<Contacts> _contact;
        private List<Contacts> _contact;
        public ListContextMenuPage()
        {
            InitializeComponent();
            lstViewElement.ItemsSource = GetContacts("");
        }

        //private ObservableCollection<Contacts> GetContacts(string searchText)
        private List<Contacts> GetContacts(string searchText)
        {
            //_contact = new List<ObservableCollection>{}
            _contact = new List<Contacts>
            {
                new Contacts{Name = "Priyansh", Details= "Frendel Kitchens Ltd"},
                new Contacts{Name = "Kupu Shah", Details= "Pharmacetical Ltd"}
            };
            if (string.IsNullOrWhiteSpace(searchText))
                return _contact;
            else
                return _contact.Where(c => c.Name.StartsWith(searchText)).ToList();
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contacts = menuItem.CommandParameter as Contacts;
            DisplayAlert("Call Clicked", contacts.Name, "OK");
        }

        /* Note : To Delete Selected contact, plz use ObservableCollection<Contacts> */
        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contacts = (sender as MenuItem).CommandParameter as Contacts;
            DisplayAlert("Delete Clicked", contacts.Name, "OK");
            _contact.Remove(contacts);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstViewElement.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}