using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmp;

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(@"1.jpg");
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            Graphics g = Graphics.FromImage(bmp);
            for (int w = 0; w < bmp.Width; w++)
            {
                for (int h = 0; h < bmp.Height; h++)
                {
                    Color color = bmp.GetPixel(w, h);
                    byte gray = (byte)((color.R * 229 + color.G * 587 + color.B * 114) / 1000);
                    bmp.SetPixel(w, h, Color.FromArgb(gray, gray, gray));
                }
            }
            g.DrawImage(bmp, 0, 0);
            pictureBox1.Image = bmp;
            g.Dispose();
            DateTime dt2 = DateTime.Now;
            TimeSpan ts1 = dt2.Subtract(dt1);
            toolStripStatusLabel1.Text = string.Format("总共花费{0}", ts1);
        }
    }
}
