using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using System.Net;
using System.Net.Mail;

namespace Android_Honeycomb_App1
{
    [Activity(Label = "Android_Honeycomb_App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class FirstActivity : Activity
    {
        
        int count = 1;
        LinearLayout _layout = null;

        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _layout = new LinearLayout(this);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnClickMe = FindViewById<Button>(Resource.Id.btnClickMe);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            btnClickMe.Click += new EventHandler(button_Click);

            Button btnClear = FindViewById<Button>(Resource.Id.btnClear);
            btnClear.Click += new EventHandler(btnClear_Click);

            Button btnShowSecond = FindViewById<Button>(Resource.Id.btnShowSecond);
            //btnShowSecond.Click += (sender, e) => { StartActivity(typeof(SecondActivity)); };
            btnShowSecond.Click += (sender, e) =>
            {
                var second = new Intent(this, typeof(SecondActivity));
                second.PutExtra("FirstData", "Data from First Activity");
                StartActivity(second);
            };

            Button btnTabbed = FindViewById<Button>(Resource.Id.btnTabbedPage);
            btnTabbed.Click += (sender, e) =>
            {
                StartActivity(typeof(TabbedActivity));
            };
                                    
        }

        void btnClear_Click(object sender, EventArgs e)
        {

            TextView textView = FindViewById<TextView>(Resource.Id.textView1);
            count = 1;
            textView.SetText(Resource.String.textView1);
            textView = FindViewById<TextView>(Resource.Id.textView2);
            textView.SetText(Resource.String.textView2);

        }

        void button_Click(object sender, EventArgs e)
        {
            
            Button button = FindViewById<Button>(Resource.Id.btnClickMe);
            TextView textView = FindViewById<TextView>(Resource.Id.textView1);

            textView.Text = string.Format("{0} clicks!", count++);
            textView = FindViewById<TextView>(Resource.Id.textView2);
            textView.Text = string.Format("{0} clicks 2!", count);            

        }

        void SwapColor(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            string color = btn.Text;
                        
        }

        private void ChangeBackgroundColor(Android.Graphics.Color color)
        {
            
            TextView tvStatus = FindViewById<TextView>(Resource.Id.tvStatus);
            try
            {
                _layout = FindViewById<LinearLayout>(Resource.Id.LayoutMain);
                _layout.SetBackgroundColor(color);
            }
            catch (Exception ex)
            {
                tvStatus.Text = string.Format("{0}", ex.ToString());
            }

        }

        private void SendTestEmail(TextView textView)
        {

            MailMessage email = null;
            SmtpClient smtp = null;

            try
            {
                email = new MailMessage("online@kingfisher-systems.co.uk", "tim@kingfisher-systems.co.uk", "Android Email", "Test email from Android App");
                smtp = new SmtpClient("mailgate.kingfisher-systems.co.uk", 25);
                smtp.Send(email);
            }
            catch (SmtpException smtpEx)
            {
                textView.Text = String.Format("{0}", smtpEx.ToString());
            }
            catch (Exception ex)
            {
                textView.Text = String.Format("{0}", ex.ToString());
            }
            finally
            {
                if (email != null)
                {
                    email.Dispose();
                    email = null;
                }
                if (smtp != null)
                {
                    smtp = null;
                }
            }

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}

