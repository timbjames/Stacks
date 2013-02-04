using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.master_pages
{
    public partial class _default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            _default master = (_default)this.Master;
            DropDownList ddlOne = (DropDownList)master.FindControl("ddlOne");

            ddlOne.Items.Insert(0, new ListItem("one", "one"));
            ddlOne.Items.Insert(1, new ListItem("two", "two"));

            ddlOne.SelectedIndexChanged += new EventHandler(ddlOne_SelectedIndexChanged);

            System.Web.UI.HtmlControls.HtmlGenericControl li = (System.Web.UI.HtmlControls.HtmlGenericControl) this.Page.Master.FindControl("liOne");
            li.Style.Add("color", "red");
            li.Attributes.Add("class", "one");

            Control li2 = this.Page.Master.FindControl("liOne");
                       

        }

        void ddlOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlOne = (DropDownList) sender;
            Response.Write(ddlOne.SelectedValue);
        }
    }
}