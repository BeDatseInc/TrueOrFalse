using TrueOrFalse;
using TrueOrFalse.iOS.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Google.MobileAds;
using UIKit;

[assembly: ExportRenderer(typeof(AdMobBannerView), typeof(AdMobBannerRenderer))]
namespace TrueOrFalse.iOS.Renderer
{
    public class AdMobBannerRenderer : ViewRenderer
    {
        BannerView adView;
        bool viewOnScreen = false;

        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }

        /// <summary>
        /// reload the view and hit up google admob 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            //convert the element to the control we want
            var adMobElement = Element;

            // Setup your BannerView, review AdSizeCons class for more Ad sizes. 
            adView = new BannerView(AdSizeCons.Banner)
            {
                AdUnitID = "ca-app-pub-5421996238963163/8238631737",
                RootViewController = UIApplication.SharedApplication.Windows[0].RootViewController
            };

            // Wire AdReceived event to know when the Ad is ready to be displayed
            adView.AdReceived += (sender, args) =>
            {
                if (!viewOnScreen)
                {
                    AddSubview(adView);
                }
                viewOnScreen = true;
            };

            adView.LoadRequest(Request.GetDefaultRequest());
            base.SetNativeControl(adView);
        }
    }
}