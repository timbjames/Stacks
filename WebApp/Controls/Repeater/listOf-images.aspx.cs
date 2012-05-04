using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Controls.Repeater
{
    public partial class listOf_images : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            images.Add(new Image() { ImageUrl = "/images/media/desert.jpg" });
            images.Add(new Image() { ImageUrl = "/images/media/desert.jpg" });
            this.rptrImages.DataSource = images;
            this.rptrImages.ItemDataBound += new RepeaterItemEventHandler(rptrImages_ItemDataBound);
            this.rptrImages.DataBind();
        }

        void rptrImages_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                Image img = (Image)e.Item.DataItem;
                Image imgBtn = (Image)e.Item.FindControl("imgButton");
                
                PlaceHolder ph = (PlaceHolder)e.Item.FindControl("phimgButton");
                ph.Controls.Add(img);
            }
        }
    }
}