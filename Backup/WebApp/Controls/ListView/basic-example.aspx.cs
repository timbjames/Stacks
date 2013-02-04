using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Controls.ListView
{
    public partial class basic_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ListView1.DataSource = Enumerable.Range(0, 10);
            this.ListView1.DataBind();
        }
    }
}