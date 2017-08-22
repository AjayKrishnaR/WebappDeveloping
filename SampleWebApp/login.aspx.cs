using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class login : System.Web.UI.Page
    {
        conclass cobj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registration/Registration.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            // if (FormsAuthentication.Authenticate(TextBox1.Text, TextBox2.Text))
            // {
            //     FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
            // }
            // else
            // {
            //     Label1.Text = "Invalid User name or Password";
            // }
            //// Response.Redirect("Welcome.aspx");

            int v = Convert.ToInt32(cobj.scalar("select count(*) from tbl_login where uname='" + TextBox1.Text + "'"));
            if (v == 1)
            {
                string uname = cobj.scalar("select uname from tbl_login where uname='" + TextBox1.Text + "'");
                if (uname == TextBox1.Text)
                {
                    string chk_paswd = cobj.scalar("select pwd from tbl_login where uname='" + TextBox1.Text + "'");
                    string paswd = TextBox2.Text;
                    string ns = FormsAuthentication.HashPasswordForStoringInConfigFile("paswd", "SHA1");
                    if (ns == chk_paswd)
                    {
                        //Session["usr"] = TextBox1.Text;                 
                        Response.Redirect("Welcome.aspx");
                    }
                    else
                    {
                        Label1.Text = "Incorrect password";
                    }
                }
                else
                {
                    Label1.Text = "Incorrect Username or Password";
                }
            }
            else
            {
                Label1.Text = "Invalid user... You need to register first!";
            }

        }
    }
}