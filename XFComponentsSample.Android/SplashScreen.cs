using Android.App;
using Android.Content.PM;
using Android.OS;

namespace XFComponentsSample.Droid
{
    [Activity(
        Label = "XFComponentsSample",
        MainLauncher = true,
        Icon = "@mipmap/icon",
        Theme = "@style/MainTheme.Splash",
        NoHistory = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(typeof(MainActivity));
        }
    }
}