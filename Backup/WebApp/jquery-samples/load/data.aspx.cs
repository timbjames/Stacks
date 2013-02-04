using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.jquery_samples.load
{

    public partial class data : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request.QueryString);
        }

    }

}