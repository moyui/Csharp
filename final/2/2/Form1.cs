using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num = 0;
        int count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            num = rd.Next(1, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = int.Parse(textBox1.Text);
            if (count < 20)
            {
                if (answer < num) 
                {
                    label2.Text = "猜小了";
                } else if(answer > num){
                    label2.Text = "猜大了";
                } else {
                    label2.Text = "恭喜你答对了！猜的次数为" + count;
                }
                if (count == 19) //最后一次猜数
                {
                    textBox1.Enabled = false;
                }
                count++;
            } else 
            {
                textBox1.Enabled = false;
                MessageBox.Show("超过20次了!", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
