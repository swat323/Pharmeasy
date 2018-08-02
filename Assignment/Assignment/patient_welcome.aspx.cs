using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class patient_welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["usern"];
            Label1.Text = "welcome "+name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Request.QueryString["usern"];
            string url = "approving.aspx?name=" + name;
            Response.Redirect(url);
        }
    }
}