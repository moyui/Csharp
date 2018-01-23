using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace _6
{
    public delegate Boolean UpdateTextHandler(long num, string name, string birth, string loc, string major, string tel, string email, string sex, long oldnum);  //定义委托
    public partial class Update : Form
    {
        public DataTable tableUp;
        public Update(DataTable table) //接受传入的table
        {
            InitializeComponent();
            tableUp = table;
        }

        public event UpdateTextHandler UpdateText;  //定义事件

        public string oldnum = ""; //保存原来学号，便于更新

        private void Update_Load(object sender, EventArgs e) //预设除学号外其他textbox不可用
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in tableUp.Rows)  //遍历行，找到学号对应的行
            {
                if (row["学号"].ToString() == textBox1.Text) //找到,可以进行修改
                {
                    //DateTime dt; //日期格式转换
                    //DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                    //dtFormat.ShortDatePattern = "yyyy/MM/dd  hh:mm:ss";
                    //dt = Convert.ToDateTime(row["出生年月"].ToString());

                    oldnum = textBox1.Text;

                    textBox2.Text = row["姓名"].ToString();
                    textBox3.Text = row["出生年月"].ToString();
                    textBox8.Text = row["性别"].ToString();
                    textBox4.Text = row["籍贯"].ToString();
                    textBox5.Text = row["专业"].ToString();
                    textBox6.Text = row["手机号"].ToString();
                    textBox7.Text = row["Email地址"].ToString();
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    textBox6.Enabled = true;
                    textBox7.Enabled = true;
                    textBox8.Enabled = true;
                    return;
                }
            }

            MessageBox.Show("找不到学号对应的学生", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);  //找不到并且不可修改,并清空
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox8.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UpdateText != null) //判断事件是否为空
            {
                UpdateText(long.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, long.Parse(oldnum));//执行委托实例
                this.Close();
            }
        }
    }
}
