using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Controls.GridView
{
    public partial class listOf_images : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            images.Add(new Image() { ImageUrl = "/images/media/desert.jpg" });
            images.Add(new Image() { ImageUrl = "/images/media/desert.jpg" });
            this.gvImages.DataSource = images;
            this.gvImages.RowDataBound += new GridViewRowEventHandler(gvImages_RowDataBound);
            this.gvImages.DataBind();
        }

        void gvImages_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

            }
        }
    }
}