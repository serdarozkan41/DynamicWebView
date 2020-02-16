using Foundation;
using UIKit;

namespace DynamicWebView.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Settings.LoadDefaultValues();
            DefaultsChanged(null);
            App.ServerURL = Settings.ServerUrl;
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }

        private void DefaultsChanged(NSNotification ob)
        {
            Settings.SetupByPreferences();
        }
    }
}
