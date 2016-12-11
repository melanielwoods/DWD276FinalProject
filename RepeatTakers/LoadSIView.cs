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
    [Activity(Label = "LoadSIView")]
    public class LoadSIView : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SIView);
            var buttonClicked = FindViewById<Button>(Resource.Id.allButton);
            buttonClicked.Click += delegate { StartActivity(typeof(LoadImageActivity)); };

        }
    }
}