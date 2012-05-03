using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Linq;

namespace ImageBrowser
{

    public partial class browser : System.Web.UI.UserControl
    {

        private string _mediaFolder;
        public string mediaFolder
        {
            get
            {
                if (!string.IsNullOrEmpty(Request["mediafolder"]))
                {
                    return Request["mediafolder"].ToString();
                }
                if (_mediaFolder != null || _mediaFolder != string.Empty)
                {
                    return _mediaFolder;
                }
                return "";
            }
            set
            {
                _mediaFolder = value;
            }
        }       
        public string errorMsg { get; set; }

        protected override void OnInit(EventArgs e)
        {           
            base.OnInit(e);                      
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            // check to see if mediaFolder is a valid path
            if (!IsValidMediaFolder())
            {
                Panel pnl = new Panel() { CssClass = "err" };
                pnl.Controls.Add(new Literal() { Text = errorMsg });
                this.phError.Controls.Add(pnl);
                return;
            }

            if (!Page.IsPostBack)
            {
                this.LoadImages();
            }

        }

        private bool IsValidMediaFolder()
        {

            if (mediaFolder == string.Empty || mediaFolder == null) { errorMsg = "Invalid Media Directory, Enter in format \"/folder/subfolder/\""; return false; }

            DirectoryInfo di = null;
            bool isValid = false;
            try
            {           
                di = new DirectoryInfo(Server.MapPath(mediaFolder));                           
                if (di.Exists)
                {
                    isValid = true;
                }
            }
            catch (Exception ex)
            {
                isValid = false;
                errorMsg = ex.ToString();
            }
            finally
            {
                if (di != null)
                {
                    di = null;
                }
            }
            return isValid;
        }

        protected internal void LoadImages()
        {

            // load images from folder
            DirectoryInfo di = new DirectoryInfo(Server.MapPath(mediaFolder));
            List<ImgObj> images = new List<ImgObj>();
            if (di.Exists)
            {
                foreach (FileInfo fi in di.GetFiles().Where(x => x.Extension.ToLower().Contains(".jpg")))
                {
                    // build into object
                    images.Add(new ImgObj() { img_name = fi.Name, img_src = mediaFolder + fi.Name });
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
                FileInfo fi = new FileInfo(Server.MapPath(mediaFolder + s));
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