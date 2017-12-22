using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml; 

namespace xamFormsApp
{
    //[XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class MainPage : ContentPage
    {
        string translatedNumber;
        public MainPage()
        {
            InitializeComponent();
            slider1.Value = 0.5;
            //Padding = new Thickness(0, 40, 0, 0);
            /*var x = new OnPlatform<Thickness> {
                iOS = new Thickness(20, 40, 20, 20),
                Android = new Thickness(20,20,20,20),
                WinPhone = new Thickness(20,20,20,20)
            };
            Padding = x;*/
        }

        void OnTranslate(object sender, EventArgs e)
        {
            translatedNumber = Core.PhonewordTranslator.ToNumber(phoneNumberText.Text);
            if (!string.IsNullOrWhiteSpace(translatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + translatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }
        }

        async void OnCall(object sender, EventArgs e)
        {
            if (await this.DisplayAlert(
                    "Dial a Number",
                    "Would you like to call " + translatedNumber + "?",
                    "Yes",
                    "No"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                    dialer.Dial(translatedNumber);
            }
        }

        private void btnHello_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message!", "Title Displayed", "OK", "Cancel");
        }

        /*private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = String.Format("Value is {0:F2}", e.NewValue);
        }*/
    }
}
