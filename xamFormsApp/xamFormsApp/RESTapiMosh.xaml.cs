using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamFormsApp
{

    public class Post
    {
        public  int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
	public partial class RestapiMosh : ContentPage
	{
	    private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
	    private ObservableCollection<Post> _lstObsercollectionsPost;
        public RestapiMosh()
		{
			InitializeComponent ();
        }
	    protected override async void OnAppearing()
	    {
	        base.OnAppearing();
	        var content = await _client.GetStringAsync(Url);
	        var jsonContent = JsonConvert.DeserializeObject<List<Post>>(content);
	        _lstObsercollectionsPost = new ObservableCollection<Post>(jsonContent);
	        lstViewPost.ItemsSource = _lstObsercollectionsPost;
	        //List<Post> lstPost = new List<Post>
	        //{
	        //    new Post() {Title = "dinosour", Body = "jurasic world"},
	        //    new Post() {Title = "dinosour1", Body = "jurasic world11"}
	        //   };
	    }
	}
}