﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new RestAPIPage();
            //MainPage = new NavigationPage(new NavInstaMasterDetailExcercise());
            //{
            //    BarBackgroundColor = Color.LightGreen,
            //    BarTextColor = Color.White
            //};
            /*MainPage = new NavigationPage(new NavigationContactSimpleMaster())
            {
                BarBackgroundColor = Color.LightGreen,
                BarTextColor = Color.White
            };*/
            //MainPage = new CarouselPageDynamic();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
