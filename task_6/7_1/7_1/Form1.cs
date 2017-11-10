using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Font = new Font("黑体", 20);
                richTextBox1.Text = "苟利国家生死以，岂因祸福避趋之。";
            }
            else 
            {
                richTextBox1.Text = "";
            }
        }
    }
}
