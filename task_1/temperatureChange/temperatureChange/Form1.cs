using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace temperatureChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double F = double.Parse(textBox1.Text);
            double C = (F - 32) * 5 / 9;
            label3.Text = String.Format("{0}", C);
        }
    }
}
