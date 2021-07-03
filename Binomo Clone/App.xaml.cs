﻿using Binomo_Clone.Pages;
using Binomo_Clone.Pages.Shell_Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Binomo_Clone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //App.Current.MainPage = new ShellHomePage();
            //MainPage = new NavigationPage(new LoginOrSignUp());
            //App.Current.MainPage = new NavigationPage(new Support());
            MainPage = new NavigationPage(new LoadingScreen());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
