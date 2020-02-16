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

            var appDefaults = new NSDictionary(serverConfigKey, "http://192.168.100.100:9000");

            NSUserDefaults.StandardUserDefaults.RegisterDefaults(appDefaults);
        }

        public static void SetupByPreferences()
        {
            ServerUrl = NSUserDefaults.StandardUserDefaults.StringForKey(serverConfigKey);
        }
    }
}