﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FortniteAndroid
{
    [Activity(Label = "DanielActivity")]
    public class DanielActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Daniel);

            Button toHome = FindViewById<Button>(Resource.Id.backButton);

            toHome.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(MainActivity));
                StartActivity(nextActivity);
            };
        }
    }
}
