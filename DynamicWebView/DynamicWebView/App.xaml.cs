using Xamarin.Forms;

namespace DynamicWebView
{
    public partial class App : Application
    {
        public static string ServerURL = "https://www.linkedin.com/in/serdarozkan41/";
        public App()
        {
            InitializeComponent();

            MainPage = new ContentPage
            {
                Title = "Dynamic WebView",
                Content = new WebView
                {
                    Source = App.ServerURL,
                    BackgroundColor = Color.White,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                }
            };
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
