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
    public partial class xmForm2 : Form
    {
        public xmForm2()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {

            if(mctextBox.Text.Trim()=="")
            {
                MessageBox.Show("项目名称不能为空！");
                Form1 f =(Form1) this.MdiParent;
                f.showmsg("项目名称不能为空！");
                return;
            }

            if (bhtextBox.Text!="")
            {
                updatedata();
                sub.writelog("更新项目信息（" + mctextBox.Text + ")");
            }
            else
            {
                insertdata();
                sub.writelog("新增项目信息（" + mctextBox.Text + ")");
            }
            mctextBox.Text = bhtextBox.Text = ddtextBox.Text = jgtextBox.Text = lxtextBox.Text = bztextBox.Text = "";
            
            rqdateTimePicker.Value = DateTime.Now;
            sjdateTimePicker.Value = DateTime.Now;

        }
        private void loadqy()
        {
            //qycomboBox.Items.Clear();
            qycheckedListBox.Items.Clear();

            string sql = "select * from Tdizhi";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //qycomboBox.Items.Add(reader["dizhi"].ToString());
                qycheckedListBox.Items.Add(reader["dizhi"].ToString());
            }
            cmd.Connection.Close();
        }

        private void xmForm2_Load(object sender, EventArgs e)
        {
            loadqy();
        }
        private int insertdata()
        {
            string sql = "insert into Txiangmu(mc,rq,sj,dd,zbjg,qy,lx,bz) values(@mc,@rq,@sj,@dd,@zbjg,@qy,@lx,@bz)";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("mc", mctextBox.Text);
            cmd.Parameters.AddWithValue("rq", rqdateTimePicker.Value.Date);
            cmd.Parameters.AddWithValue("sj", sjdateTimePicker.Value);
            cmd.Parameters.AddWithValue("dd", ddtextBox.Text);
            cmd.Parameters.AddWithValue("zbjg", jgtextBox.Text);
            cmd.Parameters.AddWithValue("qy", getqystr());
            cmd.Parameters.AddWithValue("lx", lxtextBox.Text);
            cmd.Parameters.AddWithValue("bz", bztextBox.Text);
            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return i;
        }

        private int updatedata()
        {
            string sql = "update Txiangmu set mc=@mc,rq=@rq,sj=@sj,dd=@dd,zbjg=@zbjg,qy=@qy,lx=@lx,bz=@bz where id=@id";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("mc", mctextBox.Text);
            cmd.Parameters.AddWithValue("rq", rqdateTimePicker.Value.Date);
            cmd.Parameters.AddWithValue("sj", sjdateTimePicker.Value);
            cmd.Parameters.AddWithValue("dd", ddtextBox.Text);
            cmd.Parameters.AddWithValue("zbjg", jgtextBox.Text);
            cmd.Parameters.AddWithValue("qy", getqystr());
            cmd.Parameters.AddWithValue("lx", lxtextBox.Text);
            cmd.Parameters.AddWithValue("bz", bztextBox.Text);
            cmd.Parameters.AddWithValue("id", bhtextBox.Text);
            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return i;
        }

        public void loaddata(string id)
        {
            string sql = "select * from Txiangmu where id=@id";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Connection.Open();
            SqlDataReader read = cmd.ExecuteReader();
            if(read.Read())
            {
                bhtextBox.Text = read["id"].ToString();
                mctextBox.Text = read["mc"].ToString();
                rqdateTimePicker.Value = Convert.ToDateTime(read["rq"]);
                sjdateTimePicker.Value =Convert.ToDateTime( read["sj"].ToString());
                ddtextBox.Text = read["dd"].ToString();
                jgtextBox.Text = read["zbjg"].ToString();
                setqystr( read["qy"].ToString());
                lxtextBox.Text = read["lx"].ToString();
                bztextBox.Text = read["bz"].ToString();
            }
            cmd.Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoncqzj_Click(object sender, EventArgs e)
        {
            string sql = "select top 1 [id] from Tzhuanjia where id not in(select [zjid] from Txmzj where xmid=@xmid) order by newid()";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("xmid", bhtextBox.Text);
            cmd.Connection.Open();
            SqlDataReader read = cmd.ExecuteReader();
            if(read.Read())
            {
                string id = read["id"].ToString();
                ListViewItem item = new ListViewItem();
                item.Text = id;
                item.SubItems.Add(DateTime.Now.ToString("yyyy/MM/dd hh:mm"));
                //zjlistView.Items.Add(item);
               
            }
            cmd.Connection.Close();
            /*
             * 建立专家选择窗口 ok
             * 建立项目列表窗口 ok
             * 数据库建立项目排除专家表 ok
             * 建立项目排除专家窗口 ok
             * 建立抽取专家窗口，将专家抽取操作功能移动到这个窗口
             */
        }

        private string getqystr()
        {
            string str = "";
            for (int i = 0; i < qycheckedListBox.Items.Count; i++)
            {
                if (qycheckedListBox.GetItemChecked(i))
                {
                    if (str != "")

                        str += "," + qycheckedListBox.Items[i].ToString();
                    else
                        str += qycheckedListBox.Items[i].ToString();

                }
            }
            return str;
        }
        private void setqystr(string str)
        {
            Regex regex = new Regex(@",");
            string[] s = regex.Split(str);
            if(s.Length>0)
            {
                foreach(string tmp in s)
                {
                    for(int i=0;i<qycheckedListBox.Items.Count;i++)
                    {
                        if(qycheckedListBox.Items[i].ToString()==tmp)
                        {
                            qycheckedListBox.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }
    }
}
