using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int temp = 0,
                a = x,
                b = y;
            int gongbei;
            while (b != 0)
            {
                temp = a % b;
                if (temp == 0)
                {
                    break;
                }
                else
                {
                    a = b;
                    b = temp;
                }

            }
            gongbei = x * y / b;
            label1.Text = "最大公因数是" + b.ToString() + "\n" + "最小公倍数是" + gongbei.ToString();
        }

    }
}
