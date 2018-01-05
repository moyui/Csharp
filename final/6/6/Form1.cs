using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbDataAdapter adapter;
        DataTable table = new DataTable();
        string str = @"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = student.mdb";
        private void 查看数据集ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            table.Clear();
            string sql = "Select * from student";
            adapter = new OleDbDataAdapter(sql, str);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Fill(table);
            table.DefaultView.Sort = "学号 asc";
            dataGridView1.DataSource = table;
        }

        private void 添加数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.AddText += new AddTextHandler(addData);  //添加增加数据委托
            add.ShowDialog();
            dataGridView1.DataSource = table;
        }

        private void addData(long num, string name, string birth, string loc, string major, string tel, string email, string sex)  //增加数据委托的方法
        {
            DataRow row = table.NewRow();
            row["学号"] = num;
            row["姓名"] = name;
            row["性别"] = sex;
            row["出生年月"] = birth;
            row["籍贯"] = loc;
            row["专业"] = major;
            row["手机号"] = tel;
            row["Email地址"] = email;
            table.Rows.Add(row);
            dataGridView1.EndEdit();
            adapter.Update(table);
            MessageBox.Show("已经成功添加数据", "添加数据", MessageBoxButtons.OK);
        }

        private void 删除数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.DeleteText += new DeleteTextHandler(deleteData);  //添加删除数据委托
            delete.ShowDialog();
            dataGridView1.DataSource = table;
        }

        private Boolean deleteData(long num) //删除数据委托的方法
        {
            foreach (DataRow row in table.Rows)
            {
                if (row[0].ToString()== num.ToString())
                {
                    dataGridView1.EndEdit();
                    row.Delete();
                    adapter.Update(table);
                    MessageBox.Show("成功删除该学生", "删除数据", MessageBoxButtons.OK);
                    return true;
                }
            }
            MessageBox.Show("找不到该学生", "错误", MessageBoxButtons.OK);
            return false;
        }

        private void 修改数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
