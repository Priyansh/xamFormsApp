using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamFormsApp
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        string[] strQuotes =  {"Star wars will be megha hit",
                              "In the Opposite reaction",
                              "Transforming life in to meditation"};
        int position = 0;
        public QuotesPage()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            position ++;
            if (position == strQuotes.Length)
                position = 0;
            lblQuotes.Text = strQuotes[position];
        }
    }
}