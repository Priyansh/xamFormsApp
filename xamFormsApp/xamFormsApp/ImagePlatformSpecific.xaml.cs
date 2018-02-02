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
    public partial class ImagePlatformSpecific : ContentPage
    {
        public ImagePlatformSpecific()
        {
            InitializeComponent();
            /*You can test code either by xaml or by code behind, both should work*/
            string str = "";
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    str = "clock.png";
                    break;
                case Device.Android:
                    str = "clock.png";
                    break;
                case Device.WinPhone:
                    str = "Images/clock.png";
                    break;
            }

            btnImage.Image = (FileImageSource)ImageSource.FromFile(str);
        }
    }
}