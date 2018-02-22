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
            lstActivityElement.ItemsSource = new ActivityService().GetActivities();
            lstProfileElement.ItemsSource = new ActivityService().GetActivities();
        }

        private async void lstActivityElement_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (lstActivityElement.SelectedItem == null)
                return;
            var getActivity = e.SelectedItem as Activity;
            var userInfo = new UserService().GetUser(getActivity.UserId);
            await Navigation.PushAsync(new NavInstaDetailUserInfo(userInfo));
            lstActivityElement.SelectedItem = null;
        }
    }
}
