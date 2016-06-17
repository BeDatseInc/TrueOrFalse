using System;
using Android.Gms.Ads;
using Android.Widget;
using TrueOrFalse;
using TrueOrFalse.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AdMobBannerView), typeof(AdMobBannerRenderer))]

namespace TrueOrFalse.Droid.Renderer
{
    public class AdMobBannerRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<AdMobBannerView, Android.Gms.Ads.AdView>

    //<AdMobBannerView, Android.Gms.Ads.AdView>
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {
        }

        /// <summary>
        /// reload the view and hit up google admob 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnElementChanged(ElementChangedEventArgs<AdMobBannerView> e)
        {
            base.OnElementChanged(e);
            
            try
            {
                var adMobElement = Element;
                if ((adMobElement != null) && (e.OldElement == null))
                {
                    var ad = new Android.Gms.Ads.AdView(this.Context)
                    {
                        AdSize = Android.Gms.Ads.AdSize.Banner,
                        AdUnitId = "ca-app-pub-7732124558247032/4103913702"
                    };

                    var requestbuilder = new Android.Gms.Ads.AdRequest.Builder();

                    ad.LoadAd(requestbuilder.Build());

                    this.SetNativeControl(ad);
                }
            }
            catch (Exception ex)
            {
                Toast toast = Toast.MakeText(this.Context, ex.Message, ToastLength.Long);
            }
        }

        protected override AdView CreateNativeControl()
        {
            return Control;
        }
    }

}