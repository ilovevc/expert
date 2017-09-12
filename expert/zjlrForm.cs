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
    public partial class zjlrForm : Form
    {
        public zjlrForm()
        {
            InitializeComponent();
        }

        private void zjlrForm_Load(object sender, EventArgs e)
        {
            loadqy();
        }
        private void loadqy()
        {
            comboBoxqy.Items.Clear();

            string sql = "select * from Tdizhi";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxqy.Items.Add(reader["dizhi"].ToString());
            }
            cmd.Connection.Close();
        }

        private void buttoncanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(insertdata()>0)
            {
                textBoxxm.Text = textBoxsfz.Text = textBoxdw.Text = textBoxzc.Text=textBoxzw.Text=textBoxsj.Text=textBoxdh.Text=textBoxhy.Text=textBox1zy.Text=textBoxlx.Text=textBoxbz.Text = "";
                Form1 f1 = (Form1)this.ParentForm;
                f1.showmsg("新增专家信息成功");
            }
        }

        private int insertdata()
        {
            string sql = "insert into Tzhuanjia(xingming,xingbie,nianling,shenfenzheng,danwei,zhicheng,zhiwu,shouji,dianhua,hangye,zhuanye,leixing,quyu,beizhu) values(@xingming,@xingbie,@nianling,@shenfenzheng,@danwei,@zhicheng,@zhiwu,@shouji,@dianhua,@hangye,@zhuanye,@leixing,@quyu,@beizhu)";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("xingming", textBoxxm.Text);
            cmd.Parameters.AddWithValue("xingbie", comboBoxxb.Text);
            cmd.Parameters.AddWithValue("nianling", Convert.ToInt32(textBoxnl.Text));
            cmd.Parameters.AddWithValue("shenfenzheng", textBoxsfz.Text);
            cmd.Parameters.AddWithValue("danwei", textBoxdw.Text);
            cmd.Parameters.AddWithValue("zhicheng", textBoxzc.Text);
            cmd.Parameters.AddWithValue("zhiwu", textBoxzw.Text);
            cmd.Parameters.AddWithValue("shouji", textBoxsj.Text);
            cmd.Parameters.AddWithValue("dianhua", textBoxdh.Text);
            cmd.Parameters.AddWithValue("hangye", textBoxhy.Text);
            cmd.Parameters.AddWithValue("zhuanye", textBox1zy.Text);
            cmd.Parameters.AddWithValue("leixing", textBoxlx.Text);
            cmd.Parameters.AddWithValue("quyu", comboBoxqy.Text);
            cmd.Parameters.AddWithValue("beizhu", textBoxbz.Text);

            cmd.Connection.Open();
            int i=cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return i;
        }

        public bool loaddata(string id)
        {
            string sql = "select * from Tzhuanjia where id=@id";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                textBoxbh.Text = reader["id"].ToString();
                textBoxxm.Text = reader["xingming"].ToString();
                comboBoxxb.Text = reader["xingbie"].ToString();
                textBoxnl.Text = reader["nianling"].ToString();
                textBoxsfz.Text = reader["shenfenzheng"].ToString();
                textBoxdw.Text = reader["danwei"].ToString();
                textBoxzc.Text = reader["zhicheng"].ToString();
                textBoxzw.Text = reader["zhiwu"].ToString();
                textBoxsj.Text = reader["shouji"].ToString();
                textBoxdh.Text = reader["dianhua"].ToString();
                textBoxhy.Text = reader["hangye"].ToString();
                textBox1zy.Text = reader["zhuanye"].ToString();
                textBoxlx.Text = reader["leixing"].ToString();
                comboBoxqy.Text = reader["quyu"].ToString();
                textBoxbz.Text = reader["beizhu"].ToString();
                cmd.Connection.Close();
                return true;
            }

            return false;
        }
    }
}
