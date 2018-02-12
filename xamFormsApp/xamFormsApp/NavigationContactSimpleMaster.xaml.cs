using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class NavigationContactSimpleMaster : ContentPage
    {
        public NavigationContactSimpleMaster()
        {
            InitializeComponent();
            lstContact.ItemsSource = new List<Contacts>
            {
                new Contacts{ Name = "Priyansh", Details = "Love Tesla car" },
                new Contacts{ Name = "Elon Musk", Details = "Love his work in SpaceX"}
            };
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (lstContact.SelectedItem == null)
                return;
            await Navigation.PushAsync(new NavigationContactMasterDetail(e.SelectedItem as Contacts));
            lstContact.SelectedItem = null;
        }
    }
}
