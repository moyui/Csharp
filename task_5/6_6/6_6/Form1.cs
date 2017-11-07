using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int count = int.Parse(textBox2.Text);
            int x = 0;
            List<int> list = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(i);
            }
            do
            {
                x = (x + count) % list.Count == 0 ? list.Count : (x + count) % list.Count;
                label5.Text += list[x - 1].ToString() + " ";
                list.RemoveAt(x - 1);
                x--;
            }while (list.Count > 1);
            textBox3.Text = list[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
