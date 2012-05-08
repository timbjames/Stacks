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
            this.dl1.DataSource = Enumerable.Range(0, 10);
            this.dl1.ItemCommand += new DataListCommandEventHandler(dl1_ItemCommand);
            this.dl1.DataBind();
        }

        void dl1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item)
            {
                if (e.CommandName == "Click")
                {

                }
            }
        }
    }
}