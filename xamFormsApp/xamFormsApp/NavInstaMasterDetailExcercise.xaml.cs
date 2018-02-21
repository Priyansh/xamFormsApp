using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class NavInstaMasterDetailExcercise : TabbedPage
    {
        public NavInstaMasterDetailExcercise()
        {
            InitializeComponent();
            lstViewElement.ItemsSource = new ActivityService().GetActivities();
        }
    }
}
