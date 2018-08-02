using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace Assignment
{
    public partial class pharm_welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["usern"];
            Label1.Text = "welcome pharmacist  Mr."+name;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = Request.QueryString["usern"];
            string url = "docs_approval.aspx?name=" + name;
            Response.Redirect(url);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Request.QueryString["usern"];
            string uname = TextBox1.Text;
            string reas = TextBox2.Text;
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
                con.Open();
                string insert = "insert into appr (requester,approver,reason,status) values (@requester,@approver,@reason,@status)";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@requester", name);
                cmd.Parameters.AddWithValue("@approver", uname);
                cmd.Parameters.AddWithValue("@reason", reas);
                cmd.Parameters.AddWithValue("@status", 0);
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception ex)
            {
                Response.Write(ex);
            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string name = Request.QueryString["usern"];
            string url = "approving.aspx?name=" + name;
            Response.Redirect(url);
        }
    }
}