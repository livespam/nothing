using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Calculate _Calculate;
    protected void Page_Load(object sender, EventArgs e)
    {
        _Calculate = new Calculate();
    }

    public class Calculate
    {
        public int Add(int Value1, int Value2)
        {
            return Value1 + Value2;
        }
        public int Subtract(int Value1, int Value2)
        {
            return Value1 - Value2;
        }
        public int Multiply(int Value1, int Value2)
        {
            return Value1 * Value2;
        }
        public double Divide(int Value1, int Value2)
        {
            return Value1 / Value2;
        }
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (TxtDisplay.Text == string.Empty)
        {
            Response.Write("Value is Empty!!");
        }
        else
        {
            ViewState["Value2"] = TxtDisplay.Text;
            TxtDisplay.Text = string.Empty;
            try
            {
                if ((string)ViewState["Operation"] == "Addition")
                {
                    TxtDisplay.Text = _Calculate.Add(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                }
                else if ((string)ViewState["Operation"] == "Subtraction")
                {
                    TxtDisplay.Text = _Calculate.Subtract(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                }
                else if ((string)ViewState["Operation"] == "Multiplication")
                {
                    TxtDisplay.Text = _Calculate.Multiply(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                }
                else if ((string)ViewState["Operation"] == "Division")
                {
                    TxtDisplay.Text = _Calculate.Divide(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                }
                else Response.Write("Value is Empty!!");
            }
            catch (FormatException)
            {
                Response.Write("Value is Empty!!");
            }
        }
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = TxtDisplay.Text + "1";
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = TxtDisplay.Text + "2";
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = TxtDisplay.Text + "3";
    }

    protected void btn4_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = TxtDisplay.Text + "4";
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = TxtDisplay.Text + "5";
    }

    protected void btn6_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = TxtDisplay.Text + "6";
    }

    protected void btn7_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = TxtDisplay.Text + "7";
    }

    protected void btn8_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = TxtDisplay.Text + "8";
    }

    protected void btn9_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = TxtDisplay.Text + "9";
    }

    protected void btn0_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = TxtDisplay.Text + "0";
    }


    protected void Button12_Click(object sender, EventArgs e)
    {
        if (TxtDisplay.Text == string.Empty)
        {
            Response.Write("values is empty!!");
        }
        else
        {
            ViewState["Value1"] = TxtDisplay.Text;
            ViewState["Operation"] = "Addition";
            TxtDisplay.Text = string.Empty;
        }
    }

    protected void btnMinus_Click(object sender, EventArgs e)
    {
        if (TxtDisplay.Text == string.Empty)
        {
            Response.Write("values is empty!!");
        }
        else
        {
            ViewState["Value1"] = TxtDisplay.Text;
            ViewState["Operation"] = "Subtraction";
            TxtDisplay.Text = string.Empty;
        }
    }

    protected void btnMul_Click(object sender, EventArgs e)
    {
        if (TxtDisplay.Text == string.Empty)
        {
            Response.Write("values is empty!!");
        }
        else
        {
            ViewState["Value1"] = TxtDisplay.Text;
            ViewState["Operation"] = "Multiplication";
            TxtDisplay.Text = string.Empty;
        }
    }

    protected void btnDiv_Click(object sender, EventArgs e)
    {
        if (TxtDisplay.Text == string.Empty)
        {
            Response.Write("values is empty!!");
        }
        else
        {
            ViewState["Value1"] = TxtDisplay.Text;
            ViewState["Operation"] = "Division";
            TxtDisplay.Text = string.Empty;
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        TxtDisplay.Text = "";
    }
}
