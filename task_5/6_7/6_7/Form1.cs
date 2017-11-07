using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arr = new int[1000000]; 

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                arr[i] = rd.Next(1000, 10000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            Array.Sort(arr);
            DateTime stop = DateTime.Now;
            label2.Text = start.ToString();
            label4.Text = stop.ToString();
            TimeSpan d1 = stop.Subtract(start);
            label6.Text = d1.Milliseconds.ToString() + "ms";
        }
    }
}
