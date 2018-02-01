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
	public partial class EmbeddedImageExcercise : ContentPage
	{
		public EmbeddedImageExcercise()
		{
			InitializeComponent ();
            //imageSource.Source = ImageSource.FromResource("xamFormsApp.Images.ImageNature.jpg");
        }
	}
}