
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace B4.EE.DellobelI.Droid
{
    [Activity(Label = "JIKAN", Icon = "@drawable/icon", Theme = "@style/MainTheme.Splash", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Android.Support.V7.App.AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            StartActivity(new Intent(this, typeof(MainActivity)));
        }
    }
}