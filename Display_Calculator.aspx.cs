using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculator
{
    public partial class Display_Calculator : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
                
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }


        protected void btnMul_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "*";
        }

        protected void btnResult_Click(object sender, EventArgs e)
        {

        }

        //project file .aspx.cs

        //public string[] operators = { "+", "-", "/", "*" };
        //public int a, b, c;
        //public char d;
        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}

        //protected void btn1_Click(object sender, EventArgs e)
        //{
        //    //foreach(string Op in operators)
        //    //{
        //    //    if(TextBox1.Text == Op)
        //    //    {
        //    //        TextBox1.Text = "";
        //    //        TextBox1.Text = TextBox1.Text + btn1.Text;
        //    //    }
        //    //    else
        //    //    {
        //    //        TextBox1.Text = TextBox1.Text + btn1.Text;
        //    //        break;
        //    //    }
        //    //}

        //    TextBox1.Text = TextBox1.Text + btn1.Text;
        //}

        //protected void btn2_Click(object sender, EventArgs e)
        //{
        //    //foreach (string Op in operators)
        //    //{
        //    //    if (TextBox1.Text == Op)
        //    //    {
        //    //        TextBox1.Text = "";
        //    //        TextBox1.Text = TextBox1.Text + btn2.Text;
        //    //    }
        //    //    else
        //    //    {
        //    //        TextBox1.Text = TextBox1.Text + btn2.Text;
        //    //        break;
        //    //    }
        //    //}

        //    TextBox1.Text = TextBox1.Text + btn2.Text;
        //}

        //protected void btn3_Click(object sender, EventArgs e)
        //{
        //    //foreach (string Op in operators)
        //    //{
        //    //    if (TextBox1.Text == Op)
        //    //    {
        //    //        TextBox1.Text = "";
        //    //        TextBox1.Text = TextBox1.Text + btn3.Text;
        //    //    }
        //    //    else
        //    //    {
        //    //        TextBox1.Text = TextBox1.Text + btn3.Text;
        //    //        break;
        //    //    }
        //    //}

        //    TextBox1.Text = TextBox1.Text + btn3.Text;
        //}

        //protected void btn4_Click(object sender, EventArgs e)
        //{
        //    //foreach (string Op in operators)
        //    //{
        //    //    if (TextBox1.Text == Op)
        //    //    {
        //    //        TextBox1.Text = "";
        //    //        TextBox1.Text = TextBox1.Text + btn4.Text;
        //    //    }
        //    //    else
        //    //    {
        //    //        TextBox1.Text = TextBox1.Text + btn4.Text;
        //    //        break;
        //    //    }
        //    //}

        //    TextBox1.Text = TextBox1.Text + btn4.Text;
        //}

        //protected void btn5_Click(object sender, EventArgs e)
        //{
        //    //foreach (string Op in operators)
        //    //{
        //    //    if (TextBox1.Text == Op)
        //    //    {
        //    //        TextBox1.Text = "";
        //    //        TextBox1.Text = TextBox1.Text + btn5.Text;
        //    //    }
        //    //    else
        //    //    {
        //    //        TextBox1.Text = TextBox1.Text + btn5.Text;
        //    //        break;
        //    //    }
        //    //}
        //    TextBox1.Text = TextBox1.Text + btn5.Text;

        //}

        //protected void btn6_Click(object sender, EventArgs e)
        //{
        //    //foreach (string Op in operators)
        //    //{
        //    //    if (TextBox1.Text == Op)
        //    //    {
        //    //        TextBox1.Text = "";
        //    //        TextBox1.Text = TextBox1.Text + btn6.Text;
        //    //    }
        //    //    else
        //    //    {
        //    //        TextBox1.Text = TextBox1.Text + btn6.Text;
        //    //        break;
        //    //    }
        //    //}
        //    TextBox1.Text = TextBox1.Text + btn6.Text;

        //}

        //protected void btn7_Click(object sender, EventArgs e)
        //{
        //    //foreach (string Op in operators)
        //    //{
        //    //    if (TextBox1.Text == Op)
        //    //    {
        //    //        TextBox1.Text = "";
        //    //        TextBox1.Text = TextBox1.Text + btn7.Text;
        //    //    }
        //    //    else
        //    //    {
        //    //        TextBox1.Text = TextBox1.Text + btn7.Text;
        //    //        break;
        //    //    }
        //    //}
        //    TextBox1.Text = TextBox1.Text + btn7.Text;

        //}

        //protected void btn8_Click(object sender, EventArgs e)
        //{
        //    //foreach (string Op in operators)
        //    //{
        //    //    if (TextBox1.Text == Op)
        //    //    {
        //    //        TextBox1.Text = "";
        //    //        TextBox1.Text = TextBox1.Text + btn8.Text;
        //    //    }
        //    //    else
        //    //    {
        //    //        TextBox1.Text = TextBox1.Text + btn8.Text;
        //    //        break;
        //    //    }
        //    //}
        //    TextBox1.Text = TextBox1.Text + btn8.Text;

        //}



        //protected void btn9_Click(object sender, EventArgs e)
        //{
        //    //foreach (string Op in operators)
        //    //{
        //    //    if (TextBox1.Text == Op)
        //    //    {
        //    //        TextBox1.Text = "";
        //    //        TextBox1.Text = TextBox1.Text + btn9.Text;
        //    //    }
        //    //    else
        //    //    {
        //    //        TextBox1.Text = TextBox1.Text + btn9.Text;
        //    //        break;
        //    //    }
        //    //}
        //    TextBox1.Text = TextBox1.Text + btn9.Text;

        //}



        //protected void btn0_Click(object sender, EventArgs e)
        //{
        //    //foreach (string Op in operators)
        //    //{
        //    //    if (TextBox1.Text == Op)
        //    //    {
        //    //        TextBox1.Text = "";
        //    //        TextBox1.Text = TextBox1.Text + btn0.Text;
        //    //    }
        //    //    else
        //    //    {
        //    //        TextBox1.Text = TextBox1.Text + btn0.Text;
        //    //        break;
        //    //    }
        //    //}
        //    TextBox1.Text = TextBox1.Text + btn0.Text;

        //}

        //protected void btnAdd_Click(object sender, EventArgs e)
        //{
        //    //a = Convert.ToInt32(TextBox1.Text);
        //    //d = '+';
        //    //TextBox1.Text = TextBox1.Text + d;

        //    TextBox1.Text = TextBox1.Text + '+';
        //}

        //protected void btnSub_Click(object sender, EventArgs e)
        //{
        //    //a = Convert.ToInt32(TextBox1.Text);
        //    //d = '-';
        //    TextBox1.Text = TextBox1.Text + '-';
        //}


        //protected void btnDiv_Click(object sender, EventArgs e)
        //{
        //    //a = Convert.ToInt32(TextBox1.Text);
        //    //d = '/';
        //    TextBox1.Text = TextBox1.Text + "/";
        //}



        //protected void btnMul_Click(object sender, EventArgs e)
        //{
        //    //a = Convert.ToInt32(TextBox1.Text);
        //    //d = '*';
        //    TextBox1.Text = TextBox1.Text + '*';
        //}
        //protected void btnRes_Click(object sender, EventArgs e)
        //{
        //    //c = Convert.ToInt32(TextBox1.Text);
        //    //TextBox1.Text = "";
        //    //if(d == '+')
        //    //{
        //    //    b = a + c;
        //    //    TextBox1.Text = TextBox1.Text + b;
        //    //    a = b;
        //    //}
        //    //else if (d == '-')
        //    //{
        //    //    b = a - c;
        //    //    TextBox1.Text = TextBox1.Text + b;
        //    //    a = b;
        //    //}
        //    //else if (d == '*')
        //    //{
        //    //    b = a * c;
        //    //    TextBox1.Text = TextBox1.Text + b;
        //    //    a = b;
        //    //}
        //    //else
        //    //{
        //    //    b = a / c;
        //    //    TextBox1.Text = TextBox1.Text + b;
        //    //    a = b;
        //    //}

        //    try
        //    {
        //        string expression = TextBox1.Text;
        //        var result = new DataTable().Compute(expression, "");
        //        TextBox1.Text = result.ToString();
        //    }
        //    catch
        //    {
        //        TextBox1.Text = "Error";
        //    }


        //}

        //protected void btnClear_Click(object sender, EventArgs e)
        //{
        //    TextBox1.Text = "";
        //}
    }
}