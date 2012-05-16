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
    [Activity(Label = "Tabbed Activity")]
    public class TabbedActivity : TabActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);
            // Create your application here
            SetContentView(Resource.Layout.Tabbed);

            TabHost.TabSpec spec; // Reusable TabSpec for each tab
            Intent intent; // Reusable Intent for each tab

            // create an intenr to launch Tab1 for the tab (to be reused)
            intent = new Intent(this, typeof(Tab1));
            intent.AddFlags(ActivityFlags.NewTask);

            // initialze a tabspec for each tab and add it to the tabhost
            spec = TabHost.NewTabSpec("tab1");
            spec.SetIndicator("Tab1", Resources.GetDrawable(Resource.Drawable.ic_tab_artists));
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            // do the same for other tabs
            intent = new Intent(this, typeof(Tab2));
            intent.AddFlags(ActivityFlags.NewTask);

            spec = TabHost.NewTabSpec("tab2");
            spec.SetIndicator("Tab2", Resources.GetDrawable(Resource.Drawable.ic_tab_artists));
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            intent = new Intent(this, typeof(Tab3));
            intent.AddFlags(ActivityFlags.NewTask);

            spec = TabHost.NewTabSpec("tab3");
            spec.SetIndicator("Tab3", Resources.GetDrawable(Resource.Drawable.ic_tab_artists));
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            TabHost.CurrentTab = 0;

        }
    }
}