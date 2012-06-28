using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Controls.DataList
{
    public partial class basic_datalist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.ltDateTime.Text = DateTime.Now.ToString("dddd MMM hh:ss");

            if (!Page.IsPostBack)
            {
                this.dl1.DataSource = Enumerable.Range(0, 10);
                this.dl1.ItemCommand += new DataListCommandEventHandler(dl1_ItemCommand);
                this.dl1.DataBind();

                foreach (DataListItem li in dl1.Items)
                {
                    Response.Write(((Literal)li.FindControl("ltOne")).Text);                    
                }
            }            
        }

        void dl1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item)
            {
                if (e.CommandName == "Click")
                {
                    ((Literal)e.Item.FindControl("ltOne")).Text = DateTime.Now.ToString("dddd MMM hh:ss");                    
                }
            }
        }
    }
}