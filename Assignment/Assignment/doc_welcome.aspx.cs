using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Assignment
{
    public partial class doc_welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;

            string name = Request.QueryString["usern"];
            Label1.Text = "welcome doc "+name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Request.QueryString["usern"];
            string app = TextBox1.Text;

            try
            {
                
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
                con.Open();
                string q = "select username from users where username=@username";
                SqlCommand cmd1 = new SqlCommand(q, con);
                cmd1.Parameters.AddWithValue("@username", app);
                SqlDataReader reader;
                reader = cmd1.ExecuteReader();
                
                int cnt = 0;
                while(reader.Read()) cnt++;
                con.Close();
                if (cnt==0)
                {
                    Label2.Visible = true;
                    Label2.Text = "invalid username for approver";
                }
                else
                {
                    con.Open();
                    string insert = "insert into appr (requester,approver,reason,status) values (@requester,@approver,@reason,@status)";
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@requester", name);
                    cmd.Parameters.AddWithValue("@approver", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@reason", TextBox2.Text);
                    int val = 0;
                    cmd.Parameters.AddWithValue("@status", val);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }catch(Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = Request.QueryString["usern"];
            string url = "docs_approval.aspx?name=" + name;
            Response.Redirect(url);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string name = Request.QueryString["usern"];
            string url = "approving.aspx?name=" + name;
            Response.Redirect(url);
        }
    }
}