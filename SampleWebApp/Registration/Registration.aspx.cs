﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conclass cobj = new conclass();
            int sample = 0;
            string paswd = TextBox3.Text;
            int v = Convert.ToInt32(cobj.scalar("select count(*) from tbl_login where Username='" + TextBox1.Text + "'"));
            if (v == 1)
            {
                Label1.Text = "Sorry Choose Another Username..This Is Taken !!";
            }
            else
            {
                // string ns = FormsAuthentication.HashPasswordForStoringInConfigFile("paswd", "SHA1");
                SqlConnection con = new SqlConnection("Data Source=SUYPC204;Initial Catalog=WebApp1;User ID=SA;Password=Suyati123");
                SqlCommand cmd = new SqlCommand("insert into tbl_login(Username,Password,Email,RetryAttempts,IsLocked) values('" + TextBox1.Text + "','" + paswd + "','" + TextBox4.Text + "','" + sample + "','" + sample + "')", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Text = "User Registered Successfully !!";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../login.aspx");
        }

        
    }
}