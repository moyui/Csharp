using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace _9_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                path = folderBrowserDialog1.SelectedPath;
                textBox1.Text = path;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo source = new DirectoryInfo(path);
                DirectoryInfo destination = new DirectoryInfo(textBox2.Text);
                if (!destination.Exists)
                {
                    destination.Create();
                }
                foreach (FileInfo f in source.GetFiles())
                {
                    if (f.Extension == ".docx")
                        f.CopyTo(destination.FullName + "\\" + f.Name, true);
                }
                label3.Text = "复制成功!";
            }
            catch (Exception ex)
            {
                label3.Text = "复制异常:" + ex.ToString();
            }
        }
    }
}
