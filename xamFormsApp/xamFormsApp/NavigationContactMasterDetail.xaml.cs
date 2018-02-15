using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class NavigationContactMasterDetail : ContentPage
    {
        public NavigationContactMasterDetail(Contacts contacts)
        {
            InitializeComponent();
            if (contacts is null)
                throw new ArgumentNullException();
            BindingContext = contacts;
        }
    }
}
