using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class ImagePhotoGallery : ContentPage
    {
        int id = 1;
        public ImagePhotoGallery()
        {
            InitializeComponent();
            funImageGenerate(id);
        }
        public void funImageGenerate(int id){
            imageElement.Source = new UriImageSource
            {
                Uri = new Uri("http://lorempixel.com/1920/1080/city/" + id),
                CachingEnabled = false
            };
        }
        public void btnPrevious_Clicked(object sender, System.EventArgs e)
        {
            if (id > 1)
            {
                --id;
                funImageGenerate(id);
            }
        }

        public void btnNext_Clicked(object sender, System.EventArgs e)
        {
            if (id == 10)
                id = 0;
            ++id;
            funImageGenerate(id);
        }
    }
}
