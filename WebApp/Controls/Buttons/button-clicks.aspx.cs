using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Controls.Buttons
{

    public partial class button_clicks : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ltStatus.Text = "";
            this.ltStatus.Text += "In Page_Load ";
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            this.ltStatus.Text += "Hello! " + DateTime.Now.ToLongTimeString();
            return;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            this.button1_Click(sender, e);
            return;
        }

    }

}