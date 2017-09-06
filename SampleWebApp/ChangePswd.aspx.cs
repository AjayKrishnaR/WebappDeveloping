using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class ChangePswd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["usr"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conclass cobj = new conclass();
            string cp = TextBox1.Text;
            string np = TextBox3.Text;
            string username = Session["usr"].ToString();
            string dbcp = cobj.scalar("select Password from tbl_login where Username='" + username + "'");
            if (dbcp == cp)
            {
                cobj.nonquery("update tbl_login SET Password = ('" + np + "')where Username='" + username + "'");
                Label3.Text = "Updated the new Password ";
            }
            else
            {
                Label3.Text = "Sorry we were Unable to Update ";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");

        }
    }
}