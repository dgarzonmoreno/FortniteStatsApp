using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace FortniteAndroid
{
    [Activity(Label = "Fortnite", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            //Button button3 = FindViewById<Button>(Resource.Id.button3);
            //Button button4 = FindViewById<Button>(Resource.Id.button4);
            Button toDaniel = FindViewById<Button>(Resource.Id.button1);
            Button toLuz = FindViewById<Button>(Resource.Id.button2);

            toDaniel.Click += (s, e) => 
            {
                Intent nextDaniel = new Intent(this, typeof(DanielActivity));
                StartActivity(nextDaniel);
            };

            toLuz.Click += (s, e) =>
            {
                Intent nextLuz = new Intent(this, typeof(LuzActivity));
                StartActivity(nextLuz);
            };
        }
    }
}

