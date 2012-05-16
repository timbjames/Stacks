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

namespace Android_Honeycomb_App1
{
    [Activity(Label = "My Activity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Second);

            var label = FindViewById<TextView>(Resource.Id.screen2Label);
            label.Text = Intent.GetStringExtra("FirstData") ?? "Data not available";

            
        }
    }
}