﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DataTemplateSelector
{
    public class App : Application
    {
        public App()
        {

            // The root page of your application
            
          // MainPage = new NavigationPage(new MainPage());
              MainPage = new MainPage();
          //  MainPage = new MainPageCs();
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
