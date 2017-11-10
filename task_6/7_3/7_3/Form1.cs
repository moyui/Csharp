using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = 0;
            timer1.Enabled = Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Width += 7;
        }
    }
}
