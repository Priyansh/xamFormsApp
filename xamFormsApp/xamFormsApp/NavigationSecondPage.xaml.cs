using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class NavigationSecondPage : ContentPage
    {
        public NavigationSecondPage(Contacts contacts)
        {
            InitializeComponent();
            if (contacts is null)
                throw new ArgumentNullException();
            BindingContext = contacts;
        }
    }
}
