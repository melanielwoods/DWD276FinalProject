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

namespace RepeatTakers
{
    [Activity(Label = "MainMenuActivity")]
    public class MainMenuActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Create your application here
            SetContentView(Resource.Layout.MainMenu);
            var buttonClicked = FindViewById<Button>(Resource.Id.flashcardsButton);
            buttonClicked.Click += delegate { StartActivity(typeof(LoadSIView)); };
        }


    }
}