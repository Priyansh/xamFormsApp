using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            //var ImageSrc = ImageSource.FromUri(new Uri("http://lorempixel.com/1920/1080/sports/7/"));
            var ImageSrc = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            ImageSrc.CachingEnabled = false;
            imageSource.Source = ImageSrc;
        }
    }
}
