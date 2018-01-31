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
	public partial class AbsolutePageExcercise1 : ContentPage
	{
		public AbsolutePageExcercise1 ()
		{
			InitializeComponent ();
            //var imgSrc = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/nature/7") };
            //imgSrc.CachingEnabled = false;
            //imageSource.Source = imgSrc;
        }
	}
}