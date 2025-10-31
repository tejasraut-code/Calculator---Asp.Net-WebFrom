using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculator
{
    public partial class PhoneDirectoryProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void clearfield()
        {
            fname.Text = "";
            lname.Text = "";
            phno.Text = "";
            email.Text = "";
            city.Text = "";
            state.Text = "";
        }
    
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string Firstname = fname.Text.Trim();
            string Lastname = lname.Text.Trim();
            string phone = phno.Text.Trim();
            string emailid = email.Text.Trim();
            string cityname = city.Text.Trim();
            string statename = state.Text.Trim();


            SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=ASPNetdemo;Integrated Security=True;");

            string query = "INSERT INTO PhoneDirectory (FirstName, LastName, PhoneNumber, Email, City, State) VALUES(@fname, @lname, @ph, @emailid,@city,@state)";

            conn.Open();
            using(SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fname", Firstname);
                cmd.Parameters.AddWithValue("@lname", Lastname);
                cmd.Parameters.AddWithValue("@ph",phone);
                cmd.Parameters.AddWithValue("@emailid",emailid);
                cmd.Parameters.AddWithValue("@city", cityname);
                cmd.Parameters.AddWithValue("@state",statename);

                cmd.ExecuteNonQuery();
            }
            conn.Close();
            GridView1.DataBind();
            clearfield();
        }

        protected void btnreset_Click1(object sender, EventArgs e)
        {
            clearfield();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}