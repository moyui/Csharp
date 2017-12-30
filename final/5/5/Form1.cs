using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(textBox1.Text);
            DateTime dt2 = Convert.ToDateTime(textBox2.Text);
            DateTime dt3;
            int time = int.Parse(textBox3.Text);
            int min = time % 60;
            int hour = time / 60;
            TimeSpan span = new TimeSpan(hour, min, 0);
            do
            {
                dt3 = dt1.Add(span);
                if (DateTime.Compare(dt2, dt3) < 0)
                {
                    MessageBox.Show("最后一组时间不够!", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else 
                {
                    label4.Text += string.Format("{0:t}-{1:t}\n", dt1, dt3);
                }
                dt1 = dt3;
            } while (DateTime.Compare(dt3, dt2) < 0);
        }
    }
}
