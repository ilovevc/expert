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

namespace expert
{
    public partial class pczjForm : Form
    {
        string xmid;

        public pczjForm()
        {
            InitializeComponent();
        }

        public pczjForm(string id)
        {
            xmid = id;
            InitializeComponent();
        }
        private void pczjForm_Load(object sender, EventArgs e)
        {
            loadxm(xmid);
            loaddata();
        }
        private void loadxm(string id)
        {
            string sql = "select * from Txiangmu where id=@id";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("id", xmid);
            SqlDataReader read = cmd.ExecuteReader();
            if(read.Read())
            {
                label1.Text += read["id"].ToString();
                label2.Text += read["mc"].ToString();
                
            }
            cmd.Connection.Close();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            zjselForm zjsel = new zjselForm();
            if(zjsel.ShowDialog()==DialogResult.OK)
            {

                if(isinside(xmid,zjsel.zjid))
                {
                    MessageBox.Show("该专家已在排除专家列表中。");
                    return;

                }



                loadzj(zjsel.zjid);
                dataadd(zjsel.zjid);
                sub.writelog("添加项目" + label1.Text.Substring(5) + "排除专家，编号" + zjsel.zjid);
            }
        }
        private void loadzj(string id)
        {
            string sql = "select * from Tzhuanjia where id=@id";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Connection.Open();
            SqlDataReader read = cmd.ExecuteReader();
            if(read.Read())
            {
                ListViewItem item = new ListViewItem(read["id"].ToString());
                item.SubItems.Add(read["xingming"].ToString());
                item.SubItems.Add(read["quyu"].ToString());
                item.SubItems.Add(read["hangye"].ToString());
                item.SubItems.Add(read["zhuanye"].ToString());
                listView1.Items.Add(item);
            }
            cmd.Connection.Close();
        }
        private int dataadd(string zjid)
        {
            string sql = "insert into Tpczj(zjid,xmid) values(@zjid,@xmid)";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("zjid", zjid);
            cmd.Parameters.AddWithValue("xmid", xmid);
            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return i;
        }
        private void loaddata()
        {
            listView1.Items.Clear();
            string sql = "select * from Tpczj where xmid=@xmid";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("xmid", xmid);
            cmd.Connection.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                loadzj(read["zjid"].ToString());
            }
            cmd.Connection.Close();
        }
        private bool isinside(string xid,string zjid)
        {
            string sql = "select count(*) from Tpczj where xmid=@xmid and zjid=@zjid";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("xmid", xid);
            cmd.Parameters.AddWithValue("zjid", zjid);
            cmd.Connection.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if(i>0)
            {
                return true;
            }

            return false;
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
                return;

            string tmp = listView1.SelectedItems[0].Text;
            deldata(xmid, listView1.SelectedItems[0].Text);
            loaddata();
            sub.writelog("删除项目" + label1.Text.Substring(5) + "排除专家，编号" + tmp);
        }
        private int deldata(string xid,string zjid)
        {
            string sql = "delete from Tpczj where xmid=@xmid and zjid=@zjid";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("xmid", xid);
            cmd.Parameters.AddWithValue("zjid", zjid);
            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return i;
        }
    }
}
