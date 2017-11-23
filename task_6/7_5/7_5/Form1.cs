using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fontsize = label1.Font.Size;
            if (label1.Width > this.ClientRectangle.Width)
            {
                timer1.Stop();
                timer2.Start();
            }
            label1.Font = new Font(label1.Font.FontFamily, ++fontsize);
            label1.Left = (this.ClientRectangle.Width - label1.Width) / 2;
            label1.Top = (this.ClientRectangle.Height - label1.Height) / 2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            float fontsize = label1.Font.Size;
            if (label1.Width < this.ClientRectangle.Width / 10)
            {
                timer2.Stop();
                timer1.Start();
            }
            label1.Font = new Font(label1.Font.FontFamily, --fontsize);
            label1.Left = (this.ClientRectangle.Width - label1.Width) / 2;
            label1.Top = (this.ClientRectangle.Height - label1.Height) / 2;
        }
    }
}
