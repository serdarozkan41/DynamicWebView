using DynamicWebView.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(WebView), typeof(CustomWebViewRenderer))]
namespace DynamicWebView.iOS
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            var webView = this;
            webView.ScrollView.ScrollEnabled = false;
            webView.ScrollView.Bounces = false;
        }
    }
}