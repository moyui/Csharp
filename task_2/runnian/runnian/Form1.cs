using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace runnian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                label3.Text = String.Format("{0}是闰年", year);
            }
            else
            {
                label3.Text = String.Format("{0}不是闰年", year);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
