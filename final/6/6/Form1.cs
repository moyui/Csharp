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
            dataGridView1.DataSource = table;
        }

        private void 添加数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    }
}
