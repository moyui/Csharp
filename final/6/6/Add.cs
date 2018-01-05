using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6
{
    public delegate void AddTextHandler(long num, string name, string birth, string loc, string major, string tel, string email, string sex);  //定义委托

    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        public event AddTextHandler AddText;  //定义事件

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddText != null) //判断事件是否为空
            {
                AddText(long.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);//执行委托实例
                this.Close();
            }
        }
    }
}
