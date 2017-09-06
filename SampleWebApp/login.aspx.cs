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
            int count;
            //if (FormsAuthentication.Authenticate(TextBox1.Text, TextBox2.Text))
            //{
            //    FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
            //}
            //else
            //{
            //    Label1.Text = "Invalid User name or Password";
            //}
            // Response.Redirect("Welcome.aspx");
            Session["usr"] = TextBox1.Text;

            int v = Convert.ToInt32(cobj.scalar("select count(*) from tbl_login where Username='" + TextBox1.Text + "'"));
            if (v == 1)
            {
                int check = Convert.ToInt32(cobj.scalar("select IsLocked from tbl_login where Username='" + TextBox1.Text + "'"));
                if (check == 1)
                {
                   //int checki = Convert.ToInt32(check);
                    //if (checki == 1)
                    //{
                        Label1.Text = "You Are Still Locked Contact Admin !!!";
                    //}
                }
                string uname = cobj.scalar("select Username from tbl_login where Username='" + TextBox1.Text + "'");
                if (uname == TextBox1.Text)
                {
                    string chk_paswd = cobj.scalar("select Password from tbl_login where Username='" + TextBox1.Text + "'");
                    string paswd = TextBox2.Text;
                    // string ns = FormsAuthentication.HashPasswordForStoringInConfigFile("paswd", "SHA1");
                    if (paswd == chk_paswd)
                    {
                        if (TextBox1.Text == "admin")
                        {
                            Response.Redirect("AdminHome.aspx");
                        }
                        else
                        {
                            Session["usr"] = TextBox1.Text;                 
                            //Response.Redirect("Welcome.aspx");
                            FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);
                        }
                    }
                    else
                    {
                        //Add code to check try count and lock the user
                        int tries = Convert.ToInt32(cobj.scalar("select RetryAttempts from tbl_login where Username='" + TextBox1.Text + "'"));
                       
                            count = Convert.ToInt32(tries);
                            if (count == 5)
                            {
                            int locked = 1;
                                DateTime today = DateTime.Now;
                                string Time = today.ToString("dd/MM/yyyy");
                            cobj.nonquery("update tbl_login SET LockDateTime = ('" + Time + "')where Username='" + TextBox1.Text + "'");
                           // cobj.nonquery("insert into tbl_login(LockDateTime) values('" + Time + "') where Username='" + TextBox1.Text + "'");
                            //  cobj.nonquery("insert into tbl_login(IsLocked) values(1) where Username='" + TextBox1.Text + "'");
                            cobj.nonquery("update tbl_login SET IsLocked = ('" + locked + "')where Username='" + TextBox1.Text + "'");
                            Label1.Text = "You Tried Many Times Account Locked.. Contact Admin";
                            }
                            else
                            {
                                int max_count = 5;
                                count = count + 1;
                                cobj.nonquery("update tbl_login SET RetryAttempts = ('" + count + "')where Username='" + TextBox1.Text + "'");
                                int tried = max_count - count;
                                Label1.Text = "Incorrect password " + tried + "tries left";
                            }

                        

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