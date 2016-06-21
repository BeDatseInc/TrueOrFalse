

using Android.App;
using Android.Content;
using Android.OS;

namespace TrueOrFalse.Droid
{
    [Activity(Label = "@string/app_name", MainLauncher = true, NoHistory = true, Theme = "@style/MainTheme")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           // Thread.Sleep(1000);


            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
    }
}