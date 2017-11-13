using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] arr = new double[7];
            int i = 0;
            double sum = 0;
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {                    
                    arr[i] = double.Parse(c.Text);
                    i++;
                }
            }
            Array.Sort(arr);
            for (int j = 1; j < arr.Length - 1; j++)
            {
                sum += arr[j];
            }
            label8.Text += sum / 5 + "";
        }
    }
}
