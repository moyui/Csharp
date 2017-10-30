using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rectangle rectangle1 = new rectangle();
            rectangle1.length = int.Parse(textBox1.Text);
            rectangle1.width = int.Parse(textBox2.Text);
            label1.Text = "矩形的周长为" + rectangle1.c().ToString() + "\n" + "矩形的面积为" + rectangle1.s().ToString();
        }

    }
}
