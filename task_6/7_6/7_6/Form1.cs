using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectid = listBox1.SelectedIndex;
            listBox2.Items.Add(listBox1.Items[selectid]);
            listBox1.Items.RemoveAt(selectid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectid = listBox2.SelectedIndex;
            listBox1.Items.Add(listBox2.Items[selectid]);
            listBox2.Items.RemoveAt(selectid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

    }
}
