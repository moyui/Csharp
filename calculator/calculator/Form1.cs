using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public LinkedList<string> list = new LinkedList<string>();

        public bool judgement = false;//控制数字输入

        public bool isSum = false;//判断是否已经求过和

        public double sum = 0;//累加变量

        private void button1_Click(object sender, EventArgs e)
        {
            if (!judgement)
            {
                textBox1.Text = "";
                judgement = true;
            }
            isSum = false;
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!judgement)
            {
                textBox1.Text = "";
                judgement = true;
            }
            isSum = false;
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!judgement)
            {
                textBox1.Text = "";
                judgement = true;
            }
            isSum = false;
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!judgement)
            {
                textBox1.Text = "";
                judgement = true;
            }
            isSum = false;
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!judgement)
            {
                textBox1.Text = "";
                judgement = true;
            }
            isSum = false;
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!judgement)
            {
                textBox1.Text = "";
                judgement = true;
            }
            isSum = false;
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!judgement)
            {
                textBox1.Text = "";
                judgement = true;
            }
            isSum = false;
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!judgement)
            {
                textBox1.Text = "";
                judgement = true;
            }
            isSum = false;
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!judgement)
            {
                textBox1.Text = "";
                judgement = true;
            }
            isSum = false;
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!judgement)
            {
                textBox1.Text = "";
                judgement = true;
            }
            isSum = false;
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!isSum)
            {
                list.AddLast(textBox1.Text);
                
            }
            toolStripStatusLabel1.Text += textBox1.Text;
            judgement = false;
            if (list.Count >= 3)
            {
                equal();
            }
            list.AddLast("+");            
            toolStripStatusLabel1.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!isSum)
            {
                list.AddLast(textBox1.Text);
                
            }
            toolStripStatusLabel1.Text += textBox1.Text;
            judgement = false;            
            if (list.Count >= 3)
            {
                equal();
            }            
            list.AddLast("-");
            toolStripStatusLabel1.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!isSum)
            {
                list.AddLast(textBox1.Text);
                
            }
            toolStripStatusLabel1.Text += textBox1.Text;
            judgement = false;
            if (list.Count >= 3)
            {
                equal();
            }            
            list.AddLast("*");            
            toolStripStatusLabel1.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!isSum)
            {
                list.AddLast(textBox1.Text);
                
            }
            toolStripStatusLabel1.Text += textBox1.Text;
            judgement = false;
            if (list.Count >= 3)
            {
                equal();
            }
            list.AddLast("/");
            toolStripStatusLabel1.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            list.AddLast(textBox1.Text);
            toolStripStatusLabel1.Text = "";
            equal();
        }

        public void equal()
        {
            sum = double.Parse(list.First.Value);
            list.RemoveFirst();
            while (list.Count != 0)
            {
                switch (list.First.Value)
                {
                    case "+": list.RemoveFirst(); sum += double.Parse(list.First.Value); list.RemoveFirst(); break;
                    case "-": list.RemoveFirst(); sum -= double.Parse(list.First.Value); list.RemoveFirst(); break;
                    case "*": list.RemoveFirst(); sum *= double.Parse(list.First.Value); list.RemoveFirst(); break;
                    case "/": list.RemoveFirst(); sum /= double.Parse(list.First.Value); list.RemoveFirst(); break;
                    default: break;
                }
            }
            list.Clear();
            isSum = true;
            list.AddLast(sum.ToString());
            textBox1.Text = sum.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            toolStripStatusLabel1.Text = "";
            list.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Times New Roman", 22, FontStyle.Bold);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length;
            if (length >= 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, length - 1);
            }
        }
    }
}
