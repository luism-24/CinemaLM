using CinemaLM.Helpers;
using CinemaLM.Resources;
using CinemaLM.Views;
using Plugin.Multilingual;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaLM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            TranslateExtension translate = new TranslateExtension();
            AppResources.Culture = CrossMultilingual.Current.DeviceCultureInfo;
            MainPage = new NavigationPage(new LoginPage())
            {
                BarBackgroundColor = Color.FromHex("#2f3640"),
                BarTextColor = Color.FromHex("#d63031")
            }
            ;
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
