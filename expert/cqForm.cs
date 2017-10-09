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
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;
using Excel=Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace expert
{
    public partial class cqForm : Form
    {
        string xmid;
        public cqForm()
        {
            InitializeComponent();
        }
        public cqForm(string xid)
        {

            xmid = xid;
            InitializeComponent();
        }

        private void cqForm_Load(object sender, EventArgs e)
        {
            loadqy();
            loadxm(xmid);
            loadzj();
            if(qycomboBox.Items.Count>0)
            {
                qycomboBox.SelectedIndex = 0;
            }
        }
        private void loadqy()
        {
            qycomboBox.Items.Clear();

            string sql = "select * from Tdizhi";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                qycomboBox.Items.Add(reader["dizhi"].ToString());
            }
            cmd.Connection.Close();
        }
        private void loadxm(string id)
        {
            string sql = "select * from Txiangmu where id=@id";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("id", xmid);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                label4.Text += read["id"].ToString();
                label5.Text += read["mc"].ToString();

            }
            cmd.Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=cqzj(qycomboBox.Text, zytextBox.Text, slnumericUpDown.Value.ToString());
            if(i<=0)
            {
                MessageBox.Show("未找到符合条件专家！");
            }
            else if(i<slnumericUpDown.Value)
            {
                MessageBox.Show(string.Format("数据库中符合条件专家不足{0}位，已经为您抽取{1}位专家。", slnumericUpDown.Value.ToString(), i));
            }
            loadzj();
        }
        private int cqzj(string qy,string zy,string sl)
        {
            string sql = "select top " + sl + " * from Tzhuanjia where quyu=@quyu and zhuanye=@zhuanye and id not in (select zjid from Tpczj where xmid=@xmid) and id not in (select zjid from Txmzj where xmid=@xmid) order by newid()";
            
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("quyu", qy);
            cmd.Parameters.AddWithValue("zhuanye", zy);
            cmd.Parameters.AddWithValue("xmid", xmid);
            cmd.Connection.Open();
            SqlDataReader read = cmd.ExecuteReader();
            int i=0;
            while(read.Read())
            {
                

                savezj(read["id"].ToString());
                i++;
            }
            cmd.Connection.Close();
            return i;
        }

        private int savezj(string zjid)
        {
            string sql = "insert into Txmzj(zjid,xmid,sj) values(@zjid,@xmid,@sj)";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("zjid", zjid);
            cmd.Parameters.AddWithValue("xmid", xmid);
            cmd.Parameters.AddWithValue("sj", DateTime.Now);
            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return i;
        }
        private void loadzj()
        {
            string sql = "select * from Txmzj where xmid=@xmid";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("xmid", xmid);
            cmd.Connection.Open();
            SqlDataReader read = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem(read["zjid"].ToString());
                item.SubItems.Add(Convert.ToDateTime(read["sj"]).ToString("yyyy/MM/dd hh:mm:ss"));
                listView1.Items.Add(item);
            }
            cmd.Connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
                return;

            string sql = "delete from Txmzj where xmid=@xmid and zjid=@zjid";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Parameters.AddWithValue("xmid", xmid);
            cmd.Parameters.AddWithValue("zjid", listView1.SelectedItems[0].Text);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            loadzj();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
                return;
            else
            {
                zjlrForm zjxx = new zjlrForm();
                zjxx.onlyread = true;
                zjxx.loaddata(listView1.SelectedItems[0].Text);
                
                zjxx.ShowDialog();
            }
        }
        private int savezjtoexcel(string filename)
        {
            string constr= "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False; Data Source='" + filename + "';Extended Properties='Excel 8.0;HDR=yes;IMEX=2';";
            string sql1 = "insert into [Sheet1$] values(@zjid,@xm,@xb,@nl,@dw,@hy,@zc,@zy,@dh,@sj)";
            string sql2 = "select * from Tzhuanjia where id=@zjid";
            int i = 0;
            OleDbConnection oledbcon = new OleDbConnection(constr);
            OleDbCommand oledbcmd = new OleDbCommand(sql1, oledbcon);

            SqlCommand cmd = new SqlCommand(sql2, sub.getcon());
            cmd.Connection.Open();
            oledbcmd.Connection.Open();
            foreach(ListViewItem item in listView1.Items)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("zjid", item.Text);
                SqlDataReader read = cmd.ExecuteReader();
                if(read.Read())
                {

                    oledbcmd.Parameters.Clear();
                    oledbcmd.Parameters.AddWithValue("zjid", read["id"].ToString());
                    oledbcmd.Parameters.AddWithValue("xm", read["xingming"].ToString());
                    oledbcmd.Parameters.AddWithValue("xb", read["xingbie"].ToString());
                    oledbcmd.Parameters.AddWithValue("nl", read["nianling"].ToString());
                    oledbcmd.Parameters.AddWithValue("dw", read["danwei"].ToString());
                    oledbcmd.Parameters.AddWithValue("hy", read["hangye"].ToString());
                    oledbcmd.Parameters.AddWithValue("zc", read["zhicheng"].ToString());
                    oledbcmd.Parameters.AddWithValue("zy", read["zhuanye"].ToString());
                    oledbcmd.Parameters.AddWithValue("dh", read["shouji"].ToString() + "  " + read["dianhua"].ToString());
                    oledbcmd.Parameters.AddWithValue("sj", item.SubItems[1].Text);
                    oledbcmd.ExecuteNonQuery();
                    i++;
                }
                read.Close();
            }
            cmd.Connection.Close();
            oledbcmd.Connection.Close();

            return i;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listView1.Items.Count <= 0)
                return;
            saveFileDialog1.FileName = label5.Text.Substring(5) + "(" + label4.Text.Substring(5) + ")专家抽取表";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {

                string tmppath = Path.GetTempPath() + DateTime.Now.ToString("yyyyMMddhhmmss") + ".xls";

                FileStream fs = new FileStream(tmppath, FileMode.Create, FileAccess.Write);
                fs.Write(Properties.Resources.a, 0, Properties.Resources.a.Length);
                fs.Close();

                Excel.Application app = new Excel.Application();
                Excel.Workbook workbook = app.Workbooks.Add(tmppath);
                Excel.Worksheet worksheet = workbook.ActiveSheet as Excel.Worksheet;

                worksheet.Cells[1, 1] = label5.Text.Substring(5)+ "专家抽取表";
                app.AlertBeforeOverwriting = false;
                workbook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlExcel7, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                app.Quit();

                savezjtoexcel(saveFileDialog1.FileName);
                Process.Start(saveFileDialog1.FileName);
            }
        }
    }
}
