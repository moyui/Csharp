using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.MultiColumn = true;
            int i = 0;
            int count = 1;
            while (count <= 100)
            {
                if (count % 2 != 0)
                {
                    listBox1.Items.Add(count);
                    i++;
                }
                count++;
            }
        }
    }
}
