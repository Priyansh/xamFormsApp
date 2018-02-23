using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class NavInstaMasterDetailExcercise : TabbedPage
    {
        List<AirbnbSearchGroup> SearchGroup;
        AirBnbSearchService Service;
        public NavInstaMasterDetailExcercise()
        {
            InitializeComponent();
            Service = new AirBnbSearchService();
            lstActivityElement.ItemsSource = new ActivityService().GetActivities();
            populateAirBnbSearch(Service.GetSearches());
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

        // Note that we have re-used this method twice in this class. I noticed
        // I always had to set _searchGroups and immediately set listView.ItemsSource
        // together. So, I decided to refactor these few lines into a separate
        // method (PopulateListView) to make the code cleaner. 
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
            populateAirBnbSearch(Service.GetSearches(e.NewTextValue));
        }

        private void DeleteItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var airBnbSearch = menuItem.CommandParameter as AirbnbSearch;
            DisplayAlert("Delete Selected Search", airBnbSearch.Location, "OK");
            // Locally remove the search from search groups. Since SearchGroup
            // is an ObservableCollection, this will make the search item disappear
            // from the ListView immediately.
            SearchGroup[0].Remove(airBnbSearch);
            // But we should also update the backend. So, we use SearchService for that.
            Service.DeleteSearch(airBnbSearch.Id);
        }

        private void lstAirbnbElement_Refreshing(object sender, EventArgs e)
        {
            // Note that we're using the text in the SearchBar while refreshing
            // the list of searches. This ensures that the filter is applied 
            // while refreshing the list.
            populateAirBnbSearch(Service.GetSearches(searchBarElement.Text));
            lstAirbnbElement.EndRefresh();
        }

        private void lstAirbnbElement_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var airBnbSearch = e.SelectedItem as AirbnbSearch;
            DisplayAlert("Selected Search", airBnbSearch.Location, "OK");
        }
    }
}
