using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class NavigationIntroduction : ContentPage
    {
        public NavigationIntroduction()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
           await Navigation.PopAsync();
        }
    }
}
