using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatianUKOM_1
{
    public partial class Calculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(TXTbox.Text == "0")
            {
                TXTbox.Text = "0";
            }
            else
            {
                TXTbox.Text += "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (TXTbox.Text == "0")
            {
                TXTbox.Text = "9";
            }
            else
            {
                TXTbox.Text += "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TXTbox.Text);
            TXTbox.Clear();
            operators = "/";
            TXTbox.Text = "0";
        }

        

        private void TWObtn_Click(object sender, EventArgs e)
        {
            if (TXTbox.Text == "0")
            {
                TXTbox.Text = "2";
            }
            else
            {
                TXTbox.Text += "2";
            }
        }

       

        private void ONEbtn_Click(object sender, EventArgs e)
        {
            if (TXTbox.Text == "0")
            {
                TXTbox.Text = "1";
            }
            else
            {
                TXTbox.Text += "1";
            }
        }

        private void THREEbtn_Click(object sender, EventArgs e)
        {
            if (TXTbox.Text == "0")
            {
                TXTbox.Text = "3";
            }
            else
            {
                TXTbox.Text += "3";
            }
        }

        private void FOURbtn_Click(object sender, EventArgs e)
        {
            if (TXTbox.Text == "0")
            {
                TXTbox.Text = "4";
            }
            else
            {
                TXTbox.Text += "4";
            }
        }

        private void FIVEbtn_Click(object sender, EventArgs e)
        {
            if (TXTbox.Text == "0")
            {
                TXTbox.Text = "5";
            }
            else
            {
                TXTbox.Text += "5";
            }
        }

        private void SIXbtn_Click(object sender, EventArgs e)
        {
            if (TXTbox.Text == "0")
            {
                TXTbox.Text = "6";
            }
            else
            {
                TXTbox.Text += "6";
            }
        }

        private void SEVENbtn_Click(object sender, EventArgs e)
        {
            if (TXTbox.Text == "0")
            {
                TXTbox.Text = "7";
            }
            else
            {
                TXTbox.Text += "7";
            }
        }

        private void MINUSPLUSbtn_Click(object sender, EventArgs e)
        {
             if (TXTbox.Text.Contains("-"))
            {
                TXTbox.Text = TXTbox.Text.Trim('-');
            }
            else
            {
                TXTbox.Text = "-" + TXTbox.Text;
            }
        }

        private void MINUSbtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TXTbox.Text);
            TXTbox.Clear ();
            operators = "-";
            TXTbox.Text = "0";
        }

        private void PLUSbtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TXTbox.Text);
            TXTbox.Clear();
            operators = "+";
            TXTbox.Text = "0";
        }

        private void MULTIPLYbtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TXTbox.Text);
            TXTbox.Clear();
            operators = "*";
            TXTbox.Text = "0";
        }

        

        private void EIGTHbtn_Click(object sender, EventArgs e)
        {
            if (TXTbox.Text == "0")
            {
                TXTbox.Text = "8";
            }
            else
            {
                TXTbox.Text += "8";
            }
        }

        private void EQUALbtn_Click(object sender, EventArgs e)
        {
            switch(operators) {
                case "-":
                    valueSecond = decimal.Parse(TXTbox.Text);
                    Result = valueFirst - valueSecond;
                    TXTbox.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(TXTbox.Text);
                    Result = valueFirst + valueSecond;
                    TXTbox.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(TXTbox.Text);
                    Result = valueFirst * valueSecond;
                    TXTbox.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(TXTbox.Text);
                    Result = valueFirst / valueSecond;
                    TXTbox.Text = Result.ToString();
                    break;
                case "%":
                    valueSecond = decimal.Parse(TXTbox.Text);
                    Result = valueFirst % valueSecond;
                    TXTbox.Text = Result.ToString();
                    break;
            }
        }

        private void CLEARbtn_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            TXTbox.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TXTbox.Text);
            TXTbox.Clear();
            operators = "%";
            TXTbox.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
