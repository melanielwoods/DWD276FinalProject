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
    class SIView
    {
        [Activity(Label = "RepeatTakers")]

        public class SIViewFormLoad: Activity
        {
            protected override void OnCreate(Bundle bundle)
            {
                base.OnCreate(bundle);
                SetContentView(Resource.Layout.SIView);
                var buttonClicked = FindViewById<Button>(Resource.Id.flashcardsButton);
                buttonClicked.Click += delegate { StartActivity(typeof(SIView)); };
            }

        }
    }
}