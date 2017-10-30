using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sizeyunsuan _1 = new sizeyunsuan();
            _1.x = double.Parse(textBox1.Text);
            _1.y = double.Parse(textBox2.Text);
            label1.Text = _1.plus().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sizeyunsuan _2 = new sizeyunsuan();
            _2.x = double.Parse(textBox1.Text);
            _2.y = double.Parse(textBox2.Text);
            label1.Text = _2.minus().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sizeyunsuan _3 = new sizeyunsuan();
            _3.x = double.Parse(textBox1.Text);
            _3.y = double.Parse(textBox2.Text);
            label1.Text = _3.muti().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sizeyunsuan _4 = new sizeyunsuan();
            _4.x = double.Parse(textBox1.Text);
            _4.y = double.Parse(textBox2.Text);
            label1.Text = _4.divid().ToString();
        }
    }
}
