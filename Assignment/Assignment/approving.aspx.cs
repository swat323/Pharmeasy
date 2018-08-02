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
    public partial class approving : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Request.QueryString["name"];
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
                con.Open();
                string alt = "update appr set status=1 where Id = @id";
                SqlCommand cmd = new SqlCommand(alt, con);
                int val;
                int.TryParse(TextBox1.Text, out val);
                cmd.Parameters.AddWithValue("@id", val);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect(Request.RawUrl);

            }catch(Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}