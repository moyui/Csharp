using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Juzhen juzhen = new Juzhen();

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            juzhen.length = rd.Next(1, 10);
            juzhen.width = rd.Next(1, 10);
            juzhen.arr = new int[juzhen.width, juzhen.length];
            for (int i = 0; i < juzhen.width; i++)
            {
                for (int j = 0; j < juzhen.length; j++) 
                {
                    juzhen.arr[i, j] = rd.Next(10, 100);
                    label2.Text += juzhen.arr[i, j] + " ";
                }
                label2.Text += "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] newArr = new int[juzhen.length,juzhen.width];
            for (int i = 0; i < juzhen.width; i++)
            {
                for (int j = 0; j < juzhen.length; j++)
                {
                    newArr[j, i] = juzhen.arr[i, j];
                }
            }
            for (int i = 0; i < juzhen.length; i++)
            {
                for (int j = 0; j < juzhen.width; j++)
                {
                    label4.Text += newArr[i, j] + " ";
                }
                label4.Text += "\n";
            }
        }
    }
}
