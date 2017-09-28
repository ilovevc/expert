using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace expert
{
    public partial class zjselForm : Form
    {
        public zjselForm()
        {
            InitializeComponent();
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                zjid = listView1.SelectedItems[0].Text;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }
        public string zjid
        {
            get;
            set;
        }
        private int listdata(string str="")
        {
            string sql;
            if(str=="")
            {
                sql = "select * from Tzhuanjia";

            }
            else
            {
                
                Regex regex = new Regex(@"^[0-9]+$");
                if(regex.IsMatch(str))
                {
                    sql = "select * from Tzhuanjia where id='" + str + "'";
                }
                else
                {
                    sql = "select * from Tzhuanjia where xingming='" + str + "'";
                }
            }

            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Connection.Open();
            SqlDataReader read = cmd.ExecuteReader();
            
            listView1.Items.Clear();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem(read["id"].ToString());
                item.SubItems.Add(read["xingming"].ToString());
                item.SubItems.Add(read["quyu"].ToString());
                item.SubItems.Add(read["hangye"].ToString());
                item.SubItems.Add(read["zhuanye"].ToString());
                listView1.Items.Add(item);
            }
            cmd.Connection.Close();

            if(listView1.Items.Count>0)
            {
                listView1.Items[0].Selected = true;
            }

            return listView1.Items.Count;
        }

        private void zjselForm_Load(object sender, EventArgs e)
        {
            listdata();
        }

        private void scrtoolStripButton_Click(object sender, EventArgs e)
        {
            if (scrTextBox1.Text == "输入姓名或编号查找")
                listdata();
            else
                listdata(scrTextBox1.Text);
        }

        private void scrTextBox1_Enter(object sender, EventArgs e)
        {
            if (scrTextBox1.Text == "输入姓名或编号查找")
                scrTextBox1.Text = "";
        }

        private void scrTextBox1_Leave(object sender, EventArgs e)
        {
            if (scrTextBox1.Text == "")
                scrTextBox1.Text = "输入姓名或编号查找";
        }
    }
}
