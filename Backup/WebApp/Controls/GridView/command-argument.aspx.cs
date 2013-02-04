using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Controls.GridView
{
    public partial class command_argument : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DataBoundItems> Items = new List<DataBoundItems>() { new DataBoundItems() { item = 1 } };
            this.gv1.DataSource = Items;
            this.gv1.DataBind();
        }
    }

    public class DataBoundItems
    {
        public int item { get; set; }
    }
}