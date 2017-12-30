using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(textBox1.Text);
            GregorianCalendar gc = new GregorianCalendar(); 
            int weekOfYear = gc.GetWeekOfYear(dt1,CalendarWeekRule.FirstDay, DayOfWeek.Monday); 
            label2.Text = "这一天是这一年的第" + dt1.DayOfYear.ToString() + "天";
            label3.Text = "这一天属于这一年的第" + weekOfYear.ToString() + "周";
        }
    }
}
