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
    [Activity(Label = "LoadStudyCategories")]
    public class LoadStudyCategories : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var buttonClicked = FindViewById<Button>(Resource.Id.allButton);
            buttonClicked.Click += delegate { StartActivity(typeof(StudyImage)); };
        }
    }
}