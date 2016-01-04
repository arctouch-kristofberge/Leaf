
using Android.App;
using Android.Content.PM;
using Android.OS;
using Leaf.Droid.Activities;

namespace Leaf.Droid
{
    [Activity(Label = "Leaf.Droid", Icon = "@drawable/icon", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            Xamarin.FormsMaps.Init(this, bundle);

//            LoadApplication(new App());

            StartActivity(typeof(VideoRecordActivity));
        }
    }
}