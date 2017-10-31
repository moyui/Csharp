using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            int value;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Random rnd = new Random();
                    value = rnd.Next(50, 99);
                } while (Judge(value, arr));
                arr[i] = value;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                label1.Text += arr[i] + " ";
            }
 
        }
        static Boolean Judge(int value, int[] arr) 
        {
     
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
