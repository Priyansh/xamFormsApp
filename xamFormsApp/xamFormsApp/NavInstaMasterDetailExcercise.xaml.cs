using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class NavInstaMasterDetailExcercise : TabbedPage
    {
        List<AirbnbSearchGroup> SearchGroup;
        public NavInstaMasterDetailExcercise()
        {
            InitializeComponent();
            lstActivityElement.ItemsSource = new ActivityService().GetActivities();
            var itemSearches = new AirBnbSearchService().GetSearches();
            populateAirBnbSearch(itemSearches);
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

        private void populateAirBnbSearch(IEnumerable<AirbnbSearch> itemSearches)
        {
            SearchGroup = new List<AirbnbSearchGroup>
            {
                new AirbnbSearchGroup("Recent Searches", itemSearches)
            };
            lstAirbnbElement.ItemsSource = SearchGroup;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var itemSearches = new AirBnbSearchService().GetSearches(e.NewTextValue);
            populateAirBnbSearch(itemSearches);
        }

        private void DeleteItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}
