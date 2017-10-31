using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            int[] times = new int[10];
            for (int i = 0; i < str.Length; i++) 
            {
                int value = int.Parse(str.Substring(i, 1));
                times[value]++;
            }
            for (int i = 0; i < 10; i++)
            {
                label4.Text += i + " ";
            }
            for (int i = 0; i < 10; i++)
            {
                label5.Text += times[i] + " ";
            }
        }
    }
}
