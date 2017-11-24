using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string str = "欢迎使用我设计的小程序";

        public int count = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < str.Length)
            {
                toolStripStatusLabel1.Text += str[count++];
            }
            else 
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            count = 0;
            timer2.Stop();
            timer1.Start();
        }
    }
}
