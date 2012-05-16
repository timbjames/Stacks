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
    [Activity]
    public class Tab1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            TextView tv1 = new TextView(this);
            tv1.Text = "Tab 1";
            SetContentView(tv1);
        }
    }
}