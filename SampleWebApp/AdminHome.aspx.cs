using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(GridView1 == null)
            {
                Label1.Text = "No Accounts to Unlock ";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SUYPC204;Initial Catalog=WebApp1;User ID=SA;Password=Suyati123");
            con.Open();
            SqlCommand cmd3 = new SqlCommand("resetlogin", con);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.ExecuteNonQuery();
            con.Close();
            Response.Redirect("AdminHome.aspx");
        }
    }
}