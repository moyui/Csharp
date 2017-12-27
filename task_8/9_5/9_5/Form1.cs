using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace _9_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "图像文件|*.bmp";
            DialogResult myresult = openFileDialog1.ShowDialog();
            if (myresult == DialogResult.OK)
            {
                try
                {
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    BinaryReader br = new BinaryReader(fs);
                    byte[] bmpfile = br.ReadBytes((int)fs.Length);
                    fs.Close();
                    for (int i = 0; i < bmpfile.Length; i++)
                    {
                        richTextBox1.Text += bmpfile[i].ToString("X") + " ";
                    }
                }
                catch(Exception ex)
                {
                    richTextBox1.Text = "文件打开错误" + ex.ToString();
                }
            }
        }
    }
}
