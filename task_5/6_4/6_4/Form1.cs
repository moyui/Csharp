using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            int[] arr = new int[20];
            double sum = 0;
            double avg = 0;
            double record = 0;
            int num = 0;
            for (int i = 0; i < 20; i++)
            {
                arr[i] = rd.Next(10, 100);
                sum += arr[i];
                label1.Text += arr[i] + " "; 
            }
            avg = sum / 20;
            record = Math.Abs(arr[0] - avg);
            num = arr[0];
            label1.Text += "\n平均数为：" + avg + "\n";
            for (int i = 0; i < 20; i++)
            {
                if (Math.Abs(arr[i] - avg) < record)
                {
                    record = Math.Abs(arr[i] - avg);
                    num = arr[i];
                }
            }
            label1.Text += "最接近平均值的元素是：" + num;
        }
    }
}
