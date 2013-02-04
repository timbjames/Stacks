using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApp.Controls.TreeView
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            XmlDocument xml = new XmlDocument();
            xml.Load(Server.MapPath("/Controls/TreeView/Tree.xml"));
            this.TreeView1.DataSource = xml;
            this.TreeView1.DataBind();
            this.TreeView1.DataBound += new EventHandler(TreeView1_DataBound);

        }

        void TreeView1_DataBound(object sender, EventArgs e)
        {

            this.TreeView1.Nodes[0].Selected = true;

        }
    }
}