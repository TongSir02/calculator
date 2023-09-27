using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".")) return;
            else
            { if (textBox1.Text != "") textBox1.Text += ".";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            division.Enabled = true;
            multiplication.Enabled = true;
            addition.Enabled = true;
            subtraction.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if
                (textBox1.Text != ""&& textBox1.Text != "-") textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) * -1);
            else if 
                (textBox1.Text != "-") textBox1.Text += "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&& textBox1.Text != "-") textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.01);
        }

        private void division_Click(object sender, EventArgs e)
        {
            division.Enabled = false;
            multiplication.Enabled = true;
            addition.Enabled = true;
            subtraction.Enabled = true;
            if(textBox1.Text!="")
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else textBox2.Text = "0";

        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            division.Enabled = true;
            multiplication.Enabled = false;
            addition.Enabled = true;
            subtraction.Enabled = true;
            if (textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else textBox2.Text = "0";
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            division.Enabled = true;
            multiplication.Enabled = true;
            addition.Enabled = true;
            subtraction.Enabled = false;
            if (textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else textBox2.Text = "0";
        }


        private void addition_Click(object sender, EventArgs e)
        {
            division.Enabled = true;
            multiplication.Enabled = true;
            addition.Enabled = false;
            subtraction.Enabled = true;
            if (textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else textBox2.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double right;
            double left = double.Parse(textBox2.Text);
            if (textBox1.Text == "")  right = 0;
            else  right = double.Parse(textBox1.Text);
            
            if(division.Enabled==false)
            {
                if (right != 0)
                {
                    textBox1.Text = Convert.ToString(left / right);
                    division.Enabled = true;
                }
                else
                {
                    MessageBox.Show("ERROR!");
                    textBox1.Text = "";
                    return;
                }

            }

            if (multiplication.Enabled == false)
            {             
                textBox1.Text = Convert.ToString(left * right);
                multiplication.Enabled = true;
            }
            if (addition.Enabled == false)
            {
                textBox1.Text = Convert.ToString(left + right);
                addition.Enabled = true;
            }
            if (subtraction.Enabled == false)
            {
                textBox1.Text = Convert.ToString(left - right);
                subtraction.Enabled = true;
            }
    
        }


        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            else return;

        }


        private void button18_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(x*x);
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Pow(r, 2.0));

        }
        private void button20_Click(object sender, EventArgs e)
        {
            double s = double.Parse(textBox1.Text);
            int x = (int)s;
            
            if (x != s)
            {
                MessageBox.Show("ERROR");
                textBox1.Text = "";
                return;
            }
            else
            {
                if(x==0)
                {
                    textBox1.Text = "1";
                    return;
                }
                int cnt = 1;
                for(int i = 1; i <= x; i++)
                {
                    cnt *= i;
                }
                textBox1.Text = Convert.ToString(cnt);
            }
        }
    }
}
