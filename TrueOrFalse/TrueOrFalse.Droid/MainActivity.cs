
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace TrueOrFalse.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(bundle);

            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
           
        }
        
    }
}

