using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicWebView
{
    public partial class App : Application
    {
        public static string ServerURL = "";
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
