using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamFormsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavInstaDetailUserInfo : ContentPage
	{
		public NavInstaDetailUserInfo (User user)
		{
			InitializeComponent();
            if (user is null)
                throw new ArgumentNullException();
            BindingContext = user;
		}
	}
}