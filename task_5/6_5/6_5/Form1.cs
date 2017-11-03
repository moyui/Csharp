using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string arr = textBox1.Text.ToUpper();
            int[] a = new int[26];
            char max = '0';
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int s1 = char.Parse(arr.Substring(i, 1)) - 'A';
                if (s1 >= 0 && s1 <= 25)
                {
                    a[s1]++;
                }
            }
            for (int i = 0; i <= 25; i++)
            {
                if (a[i] > count)
                {
                    count = a[i];
                    max = Convert.ToChar(i + 'A');
                }
            }
            label1.Text = "最多字符是：" + max + " 次数为：" + count;
        }
    }
}
