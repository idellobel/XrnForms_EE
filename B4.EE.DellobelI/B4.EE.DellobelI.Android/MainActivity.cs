
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace B4.EE.DellobelI.Droid
{
    [Activity(Label = "JIKAN", Theme = "@style/MainTheme" )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

