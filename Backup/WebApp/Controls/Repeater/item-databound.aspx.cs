using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Controls.Repeater
{
    public partial class item_databound : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            this.rptr1.DataSource = Enumerable.Range(0, 10);
            this.rptr1.ItemDataBound += new RepeaterItemEventHandler(rptr1_ItemDataBound);
            this.rptr1.DataBind();
        }

        void rptr1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                Literal lt = new Literal() { Text = string.Format(" Index {0} ", e.Item.ItemIndex.ToString()) };
                PlaceHolder ph = (PlaceHolder)e.Item.FindControl("placeHolder1");
                ph.Controls.Add(lt);
            }
        }

    }
}