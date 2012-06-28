using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApp.cookie_compliance
{
    public partial class custom : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            this.btnSave.Click += new EventHandler(btnSave_Click);
        }

        void btnSave_Click(object sender, EventArgs e)
        {

            string template = string.Empty;
            FileStream fs = File.Create(Server.MapPath("//cookie-compliance//template//" + this.tbCustom.Text + ".js"));
            fs.Close();

            string line = string.Empty;            
            StreamReader sr = new StreamReader(Server.MapPath("//cookie-compliance//template//custom.txt"));

            line = sr.ReadLine();
            while (line != null)
            {
                template += line;
                line = sr.ReadLine();
            }
            sr.Close();

            template = template.Replace("##CUSTOM##", this.tbCustom.Text);

            StreamWriter sw = new StreamWriter(Server.MapPath("//cookie-compliance//template//" + this.tbCustom.Text + ".js"));
            sw.WriteLine(template);
            sw.Close();
                        
            this.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "JS", "<script src=\"/cookie-compliance/template/" + this.tbCustom.Text + ".js\"></script>", false);
            this.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "JS2", "$(function(){ $.euCookieCompliance(); });", true);

        }

    }
}