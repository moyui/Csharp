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
    public delegate Boolean DeleteTextHandler(long num);  //定义委托

    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        public event DeleteTextHandler DeleteText;  //定义事件

        private void button1_Click(object sender, EventArgs e)
        {
            if (DeleteText != null) //判断事件是否为空
            {
                DeleteText(long.Parse(textBox1.Text));//执行委托实例
                this.Close();
            }
        }
    }
}
