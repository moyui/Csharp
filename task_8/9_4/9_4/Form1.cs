using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace _9_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "文本文件|*.txt";
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                label1.Text = "地址：" + openFile.FileName.ToString();
                FileStream fs = new FileStream(openFile.FileName, FileMode.Open);
                richTextBox1.Text = "";
                Byte[] readstream = new Byte[30];
                while (fs.Read(readstream, 0, 30) > 0)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        richTextBox1.Text += (char)readstream[i];
                    }
                }
            }
        }
    }
}
