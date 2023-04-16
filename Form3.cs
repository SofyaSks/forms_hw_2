using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_hw_2
{
    
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();

        }

        private void button_0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            label1.Text += "-";
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            label1.Text += "/";
        }

        private void button_equals_Click(object sender, EventArgs e)
        {

            char s = ' ';
            string str = label1.Text;
            foreach (char item in str)
            {
                if (item == '+' || item == '*' || item == '/' || item == '-')
                {
                    s = item;
                    break;
                }
            }

            string[] num = str.Split(s); 
            double res = 0;

            switch (s)
            {
                case '+':
                    res = double.Parse(num[0]) + double.Parse(num[1]);
                    break;
                case '-':
                    res = double.Parse(num[0]) - double.Parse(num[1]);
                    break;
                case '*':
                    res = double.Parse(num[0]) * double.Parse(num[1]);
                    break;
                case '/':
                    try
                    {
                        res = double.Parse(num[0]) / double.Parse(num[1]);
                    }
                    catch(DivideByZeroException div)
                    {
                        MessageBox.Show(div.Message);
                    }
                    break;
            }

            label1.Text = res.ToString();
        }
    }
}
