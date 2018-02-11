using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class NavigationWelcome : ContentPage
    {
        public NavigationWelcome()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
           await Navigation.PushAsync(new NavigationIntroduction());
        }
    }
}
