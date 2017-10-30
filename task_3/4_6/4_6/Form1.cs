using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student student_1 = new student();
            student_1.yuwen = double.Parse(textBox1.Text);
            student_1.shuxue = double.Parse(textBox2.Text);
            student_1.yinyu = double.Parse(textBox3.Text);
            label4.Text = student_1.show();
        }
    }
}
