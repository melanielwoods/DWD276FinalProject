using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using SQLite;
using Android.Content;
using Android.Runtime;

namespace RepeatTakers
{
    [Activity(Label = "RepeatTakers2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            var buttonClicked = FindViewById<Button>(Resource.Id.loginButton);
            buttonClicked.Click += delegate { StartActivity(typeof(MainMenuActivity)); };
        }
    }
}

