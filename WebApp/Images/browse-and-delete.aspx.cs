using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApp.Images
{

    public partial class browse_and_delete : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.LoadImages();
            }
            
        }
        
        protected internal void LoadImages()
        {
            
            // load images from folder
            DirectoryInfo di = new DirectoryInfo(Server.MapPath("/images/media/"));
            List<ImgObj> images = new List<ImgObj>();
            if (di.Exists)
            {
                foreach (FileInfo fi in di.GetFiles().Where(x => x.Extension.ToLower().Contains(".jpg")))
                {
                    // build into object
                    images.Add(new ImgObj() { img_name = fi.Name, img_src = "/images/media/" + fi.Name });
                }
            }

            this.rptr.DataSource = images;            
            this.rptr.DataBind();

            if (images == null || images.Count == 0)
            {
                this.rptr.Visible = false;
            }

        }

        protected void Button_OnClick(object sender, EventArgs e)
        {
            List<string> imagesToDelete = new List<string>();
            foreach (RepeaterItem item in this.rptr.Items)
            {
                if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
                {
                    CheckBox chk = (CheckBox)item.FindControl("chkDelete");
                    if (chk.Checked)
                    {
                        // flag for deletion
                        string fname = ((Label)item.FindControl("lblFileName")).Text;
                        imagesToDelete.Add(fname);
                    }
                }
            }

            foreach (string s in imagesToDelete)
            {
                FileInfo fi = new FileInfo(Server.MapPath("/images/media/" + s));
                fi.Delete();
            }

            this.LoadImages();
        }

    }

    public class ImgObj
    {
        public string img_src { get; set; }
        public string img_name { get; set; }
    }
}