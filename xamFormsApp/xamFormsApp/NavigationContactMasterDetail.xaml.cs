using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class NavigationContactMasterDetail : MasterDetailPage
    {
        public NavigationContactMasterDetail()
        {
            InitializeComponent();
            lstContact.ItemsSource = new List<Contacts>
            {
                new Contacts{ Name = "Priyansh", Details = "Love Tesla car" },
                new Contacts{ Name = "Elon Musk", Details = "Love his work in SpaceX"}
            };
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contacts;
            Detail = new NavigationPage(new NavigationDetailPage(contact));
            IsPresented = false;
        }
    }
}
