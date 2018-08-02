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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
                con.Open();
                string u_name = TextBox1.Text;
                string psw = TextBox2.Text;
                string que = "select username,password,type from users where username = @username and password = @password";

                SqlCommand cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("@username", u_name);
                cmd.Parameters.AddWithValue("@password", psw);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                int cnt = 0; int t1 =-1;
                while (reader.Read())
                {
                    cnt++;
                    u_name = reader["username"].ToString();
                    psw = reader["password"].ToString();
                    int.TryParse(reader["type"].ToString(),out t1);
                    
                }
                if(cnt != 1)
                {
                    Label1.Visible = true;
                    Label1.Text = "Invalid username or password";
                }
                else
                {
                    
                    if (t1 == 0)
                        Response.Redirect("insert_into_users.aspx");
                    if (t1 == 1)
                    {
                        string url = "patient_welcome.aspx?usern=" + u_name;
                        Response.Redirect(url);

                    }
                    if (t1 == 2)
                    {
                        string url = "doc_welcome.aspx?usern=" + u_name;
                        Response.Redirect(url);
                    }
                    if (t1 == 3)
                    {
                        string url = "pharm_welcome.aspx?usern=" + u_name;
                        Response.Redirect(url);

                    }
                }
            }catch(Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}