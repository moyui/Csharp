using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace _8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int count = 1;

        private void 结束运行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult myresult = openFileDialog1.ShowDialog();
            if (myresult == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string temp = "";
                while(!sr.EndOfStream)  //读到文件流结尾退出
                {
                temp += sr.ReadLine() + "\n";
                }
                richTextBox1.Text += "第" + count++ + "个文件:\n" + temp + "\n";
                sr.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文件|*.txt";
        }
    }
}
