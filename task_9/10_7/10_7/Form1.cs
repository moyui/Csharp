using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics gMouse;
        Point p1, ptStart, ptMove;
        Pen mypen = new Pen(Color.Black);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            gMouse = pictureBox1.CreateGraphics();
            p1.X = e.X;
            p1.Y = e.Y;
            ptStart = p1;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ptMove.X = e.X;
                ptMove.Y = e.Y;
                gMouse.DrawLine(mypen, ptStart, ptMove);
                ptStart = ptMove;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;
            gMouse.DrawLine(mypen, p1, ptStart);
        }
    }
}
