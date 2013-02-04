using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Controls.CheckboxList
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<CBL> cbl = new List<CBL>();
            cbl.Add(new CBL() { theText = "one", theValue = "1" });
            cbl.Add(new CBL() { theText = "two", theValue = "2" });
            cbl.Add(new CBL() { theText = "three", theValue = "3" });

            this.chkList.DataSource = cbl;
            this.chkList.DataTextField = "theText";
            this.chkList.DataValueField = "theValue";
            this.chkList.DataBind();
        }
    }

    public class CBL
    {
        public string theText { get; set; }
        public string theValue { get; set; }
    }
}