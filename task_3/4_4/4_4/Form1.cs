using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ball ball1 = new Ball();
            ball1.R = double.Parse(textBox1.Text);
            label1.Text = "球体的表面积是：" + ball1.s().ToString() + "\n" + "球体的体积是：" + ball1.v().ToString();
        }
    }
}
