using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SampleWebApp
{
    public class conclass
    {
        SqlConnection con = new SqlConnection("Data Source=SUYPC204;Initial Catalog=WebApp1;User ID=SA;Password=Suyati123");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public conclass()
        {
            cmd.Connection = con;
        }
        public void openconnection()
        {
            if (con.State == ConnectionState.Open)
            { con.Close(); }
            con.Open();
        }
        //------------------------------insert,update,delete----------------//
        public string nonquery(string s)
        {
            openconnection();
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            return "1";
        }
        //------------------------------single value retrieval-------------//
        public string scalar(string s)
        {


            openconnection();
            cmd.CommandText = s;
            string a = cmd.ExecuteScalar().ToString();
            return a;
        }
        //------------------retrive a row, database or datatable-----------//
        public DataTable getvaluefill(string s)
        {
            dt.Clear();
            openconnection();
            cmd.CommandText = s;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }



    }
}