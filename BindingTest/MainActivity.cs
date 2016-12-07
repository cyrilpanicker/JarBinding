using Android.App;
using Android.Widget;
using Android.OS;
using Com.Squareup.Picasso;

namespace BindingTest {
    [Activity(Label = "BindingTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            var imageView = FindViewById<ImageView>(Resource.Id.imageView);
            Picasso.With(this)
                .Load("http://i.imgur.com/DvpvklR.jpg")
                .Into(imageView);
        }
    }
}

