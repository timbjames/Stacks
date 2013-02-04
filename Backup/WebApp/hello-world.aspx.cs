using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WebApp
{
    public partial class hello_world : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlInputText tb = this.tbOne;
            tb.Value = "Hello World !!!";
            //string theVal = Request.Form[""].ToString();

            string script = "Hello\nWorld";
            ClientScript.RegisterStartupScript(GetType(), "test", String.Format("alert(\"{0}\");", script), true);

        }

        protected void ClickedMe(object sender, EventArgs e)
        {
            Response.Write("HELLO WORLD");
        }
    }
}