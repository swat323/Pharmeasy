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
    public partial class insert_into_users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
                con.Open();
                string insert = "insert into users (username,password,type) values (@username,@password,@type)";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@username", TextBox2.Text);
                cmd.Parameters.AddWithValue("@password", TextBox1.Text);
                int t1 = 0;
                int.TryParse(TextBox3.Text,out t1);
                cmd.Parameters.AddWithValue("@type", t1);
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception ex)
            {
                Response.Write(ex);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("users_data.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
                con.Open();
                string del = "delete from users";
                SqlCommand cmd = new SqlCommand(del, con);
               
               
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}