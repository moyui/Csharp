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

        public int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            progressBar1.PerformStep();
            pictureBox1.Width += 10;
            if (i == 50)
            {
                timer1.Stop();
            }
        }
    }
}
