using Foundation;

namespace DynamicWebView.iOS
{
    public class Settings
    {
        public static string ServerUrl { get; private set; }

        const string serverConfigKey = "serverConfig";

        public static void LoadDefaultValues()
        {
            var settingsDict = new NSDictionary(NSBundle.MainBundle.PathForResource("Settings.bundle/Root.plist", null));

            var prefSpecifierArray = settingsDict["PreferenceSpecifiers"] as NSArray;

            foreach (var prefItem in NSArray.FromArray<NSDictionary>(prefSpecifierArray))
            {
                var key = (NSString)prefItem["Key"];
                if (key == null)
                    continue;

                var val = prefItem["DefaultValue"];
                switch (key.ToString())
                {
                    case serverConfigKey:
                        ServerUrl = val.ToString();
                        break;
                }
            }

            var appDefaults = new NSDictionary(serverConfigKey, "https://www.linkedin.com/in/serdarozkan41/");

            NSUserDefaults.StandardUserDefaults.RegisterDefaults(appDefaults);
        }

        public static void SetupByPreferences()
        {
            ServerUrl = NSUserDefaults.StandardUserDefaults.StringForKey(serverConfigKey);
        }
    }
}