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

        public double ans = 0;

        public LinkedList<string> link = new LinkedList<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            toolStripStatusLabel1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            toolStripStatusLabel1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            toolStripStatusLabel1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            toolStripStatusLabel1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            toolStripStatusLabel1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            toolStripStatusLabel1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            toolStripStatusLabel1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
            toolStripStatusLabel1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
            toolStripStatusLabel1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            toolStripStatusLabel1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "+";
            toolStripStatusLabel1.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-";
            toolStripStatusLabel1.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "*";
            toolStripStatusLabel1.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/";
            toolStripStatusLabel1.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = ".";
            toolStripStatusLabel1.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            int length = toolStripStatusLabel1.Text.Length;
            if (length > 0)
            {
                toolStripStatusLabel1.Text = toolStripStatusLabel1.Text.Substring(0, length - 1);    
            }
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            toolStripStatusLabel1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Times New Roman", 22, FontStyle.Bold);
        }


    }
}
