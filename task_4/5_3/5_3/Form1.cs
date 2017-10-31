using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDay = Convert.ToDateTime(textBox1.Text);
            DateTime startDay1 = startDay;
            DateTime endDay = Convert.ToDateTime(textBox2.Text);
            int i = 0;
            while (startDay != endDay)
            { 
                String day = startDay.DayOfWeek.ToString();
                if (day != "Saturday" && day != "Sunday")
                {
                    i++;
                }
                startDay = startDay.AddDays(1);
            }
            label3.Text = string.Format("{0:D}到{1:D}之间的工作日共有{2}天", startDay1, endDay, i);
        }
    }
}
