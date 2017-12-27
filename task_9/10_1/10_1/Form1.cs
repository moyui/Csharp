using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmp = new Bitmap("1.jpg");

        int pWidth = 0, pHeight = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle((this.Width - pWidth) / 2 - 10, (this.Height - pHeight) / 2 - 10, pWidth, pHeight);
            Graphics g = this.CreateGraphics();
            pWidth += bmp.Width / 100;
            pHeight += bmp.Height / 100;
            if ((pWidth > this.Width) || (pHeight > this.Height))
            {
                timer1.Enabled = false;
            }
            else
            {
                g.DrawImage(bmp, rect);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }
    }
}
