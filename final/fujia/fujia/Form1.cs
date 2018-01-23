using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace fujia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();  //打开读取框
            openFile.Filter = "文本文件|*.txt";  //过滤特定文件
            DialogResult myresult = openFile.ShowDialog();
            if (myresult == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName); //打开字符流
                richTextBox1.Text = sr.ReadToEnd();  //读取字符
            }
        }

        private void 统计字数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int chnum = 0, egnum = 0, num = 0, oth = 0, line = 1;
            foreach (char ch in richTextBox1.Text)
            {
 
            }

            foreach (char ch in richTextBox1.Text)
            {
                if (ch == '\n'|| ch == '\r') 
                    line++; //统计行数
                if (ch >= 0x4e00 && ch <=0xf9bb) 
                    chnum++; //统计中文字符
                if (ch >= '0' && ch <= '9')
                    num++; //统计数字
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A') && (ch <= 'Z'))
                    egnum++; //统计英文字符
                if ("`~!@#$%^&*()_+-={}[]:\";'<>,.?/\\| ".IndexOf(ch) != -1) //换行没算在里面
                    oth++; //统计其他字符
            }
            MessageBox.Show(string.Format("中文字数：{0}\n英文字数：{1}\n数字字数:{2}\n其他字符：{3}\n行数：{4}", chnum, egnum, num, oth, line), "统计字数", MessageBoxButtons.OKCancel);
        }

        private void 结束运行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();  //关闭
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "学号： 1513490428 姓名：高夕毓";
        }
    }
}
