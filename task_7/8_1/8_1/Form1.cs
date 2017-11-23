using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult myresult = openFileDialog1.ShowDialog();
           if (myresult == DialogResult.OK)
           {   
               //pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
               pictureBox1.ImageLocation = openFileDialog1.FileName;
               toolStripStatusLabel1.Text = "被打开的图片文件名：" + openFileDialog1.FileName;
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片文件|*.jpg;*.png;*.gif|所有文件|*.*";
        }
    }
}
