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
    [Activity(Label = "LoadImageActivity")]
    public class LoadImageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //write code to scroll through image list when next button is clicked
            var imageView = FindViewById<ImageView>(Resource.Id.studyImageView);
            var btnPrevious = FindViewById<Button>(Resource.Id.previousBtn);
            var btnNext = FindViewById<Button>(Resource.Id.nextBtn);

            btnPrevious.Click += (e, o) =>
             {
                 imageView.SetImageResource(Resource.Drawable.i29);
                 btnNext.Visibility = ViewStates.Visible;
                 btnPrevious.Visibility = ViewStates.Invisible;
             };

            btnNext.Click += (e, o) =>
            {
                imageView.SetImageResource(Resource.Drawable.i38);
                btnPrevious.Visibility = ViewStates.Visible;
                btnNext.Visibility = ViewStates.Invisible;
            };
        }


    }
}