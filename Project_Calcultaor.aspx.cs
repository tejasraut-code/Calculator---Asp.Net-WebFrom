using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculator
{
    public partial class Project_cal : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + btn1.Text;
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + btn2.Text;
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + btn3.Text;
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + btn4.Text;
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + btn5.Text;
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + btn6.Text;
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + btn7.Text;
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + btn8.Text;
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + btn9.Text;
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + btn0.Text;
        }

        protected void btndot_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + ".";
        }

        //Operators
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '+';
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '-';
        }


        protected void btnDiv_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "/";
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '*';
        }

        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Calculator;Integrated Security=True;");
        //Result Btn
        protected void btnRes_Click(object sender, EventArgs e)
        {
           
            try
            {
                string expression = TextBox1.Text;
                var result = new DataTable().Compute(expression, "");
                TextBox1.Text = result.ToString();


                string query = "insert into History (Operation,Total) Values(@expression, @total)";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@expression", expression);
                    cmd.Parameters.AddWithValue("@total", result.ToString());
                    cmd.ExecuteNonQuery();
                }
                GridView1.DataBind();
            }
            catch
            {
                TextBox1.Text = "Error";
            }
        }


        //CLear btn
        protected void btnClear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        //Delete btn
        protected void btnDel_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length > 0)
            {
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}