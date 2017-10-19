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

namespace expert
{
    public partial class Form1 : Form
    {
        quyuform fquyu=null;
        zjlrForm fzjlr = null;
        zjlistForm fzjlist = null;
        xmForm2 fxm = null;
        xmlsForm fxmls = null;
        logForm flog = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void 区域信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(fquyu!=null && !fquyu.IsDisposed)
            {
                fquyu.WindowState = FormWindowState.Normal;
                fquyu.Focus();
            }
            else
            {
                fquyu = new quyuform();
                fquyu.MdiParent = this;
                fquyu.Show();
            }
            
        }

        private void 专家信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fzjlr != null && !fzjlr.IsDisposed)
            {
                fzjlr.WindowState = FormWindowState.Normal;
                fzjlr.Focus();
                
            }
            else
            {
                fzjlr = new zjlrForm();
                fzjlr.MdiParent = this;
                fzjlr.Show();
                //fzjlr.loaddata("100001");
            }
        }
        public void showmsg(string msg)
        {
            toolmsg.Text = msg;
        }

        private void 专家列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fzjlist != null && !fzjlist.IsDisposed)
            {
                fzjlist.WindowState = FormWindowState.Normal;
                fzjlist.Focus();
            }
            else
            {
                fzjlist = new zjlistForm();
                fzjlist.MdiParent = this;
                fzjlist.Show();
            }
        }

        public zjlrForm zjlrform
        {
            get
            {
                if (fzjlr != null && !fzjlr.IsDisposed)
                {
                    fzjlr.WindowState = FormWindowState.Normal;
                    fzjlr.Focus();

                }
                else
                {
                    fzjlr = new zjlrForm();
                    fzjlr.MdiParent = this;
                    fzjlr.Show();
                    //fzjlr.loaddata("100001");
                }
                return fzjlr;
            }
        }
        public xmForm2 xmform
        {
            get
            {
                if (fxm != null && !fxm.IsDisposed)
                {
                    fxm.WindowState = FormWindowState.Normal;
                    fxm.Focus();
                }
                else
                {
                    fxm = new xmForm2();
                    fxm.MdiParent = this;
                    fxm.Show();
                }
                return fxm;
            }
        }

        private void 项目信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fxm != null && !fxm.IsDisposed)
            {
                fxm.WindowState = FormWindowState.Normal;
                fxm.Focus();
            }
            else
            {
                fxm = new xmForm2();
                fxm.MdiParent = this;
                fxm.Show();
            }
           // fxm.loaddata("100001");
        }

        private void 项目列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fxmls != null && !fxmls.IsDisposed)
            {
                fxmls.WindowState = FormWindowState.Normal;
                fxmls.Focus();
            }
            else
            {
                fxmls = new xmlsForm();
                fxmls.MdiParent = this;
                fxmls.Show();
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            fxmls = new xmlsForm();
            fxmls.MdiParent = this;
            fxmls.Show();
            sub.IsReg = sub.IsRegsoft();
        }

        private void 导出专家数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create,FileAccess.Write);
                fs.Write(Properties.Resources.b, 0, Properties.Resources.b.Length);
                fs.Close();

                zjtoexcel(saveFileDialog1.FileName);
                Process.Start(saveFileDialog1.FileName);

                sub.writelog("导出专家数据表");
            }
        }
        private int zjtoexcel(string filename)
        {
            string sql1 = "select * from Tzhuanjia";
            string sql2 = "insert into [Sheet1$] values(@zjid,@xm,@xb,@nl,@sfz,@dw,@zc,@zw,@sj,@dh,@hy,@zy,@lx,@qy,@bz)";
            //string olecon = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False; Data Source='" + filename + "';Extended Properties='Excel 8.0;HDR=yes;IMEX=2';";
            string olecon = "Provider=Microsoft.ACE.OLEDB.12.0;Persist Security Info=False; Data Source='" + filename + "';Extended Properties='Excel 12.0;HDR=yes;IMEX=0';";
            SqlCommand cmd1 = new SqlCommand(sql1, sub.getcon());
            OleDbCommand cmd2 = new OleDbCommand(sql2, new OleDbConnection(olecon));
            cmd1.Connection.Open();
            cmd2.Connection.Open();
            SqlDataReader read = cmd1.ExecuteReader();
            int i = 0;
            while(read.Read())
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("zjid", read["id"].ToString());
                cmd2.Parameters.AddWithValue("xm", read["xingming"].ToString());
                cmd2.Parameters.AddWithValue("xb", read["xingbie"].ToString());
                cmd2.Parameters.AddWithValue("nl", read["nianling"].ToString());
                cmd2.Parameters.AddWithValue("sfz", read["shenfenzheng"].ToString());
                cmd2.Parameters.AddWithValue("dw", read["danwei"].ToString());
                cmd2.Parameters.AddWithValue("zc", read["zhicheng"].ToString());
                cmd2.Parameters.AddWithValue("zw", read["zhiwu"].ToString());
                cmd2.Parameters.AddWithValue("sj", read["shouji"].ToString());
                cmd2.Parameters.AddWithValue("dh", read["dianhua"].ToString());
                cmd2.Parameters.AddWithValue("hy", read["hangye"].ToString());
                cmd2.Parameters.AddWithValue("zy", read["zhuanye"].ToString());
                cmd2.Parameters.AddWithValue("lx", read["leixing"].ToString());
                cmd2.Parameters.AddWithValue("qy", read["quyu"].ToString());
                cmd2.Parameters.AddWithValue("bz", read["beizhu"].ToString());
                cmd2.ExecuteNonQuery();
                i++;
            }

            cmd1.Connection.Close();
            cmd2.Connection.Close();
            return i;
        }

        private void 导入专家数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                int i = exceltozj(openFileDialog1.FileName);
                if (i > 0)
                {
                    MessageBox.Show("导入成功，共导入数据" + i.ToString() + "条。");
                    sub.writelog("导入专家数据" + i.ToString() + "条。");
                }
                    
                else
                    MessageBox.Show("导入数据失败，请确认文件格式正确，并有数据存在。");
            }
        }

        private int exceltozj(string filename)
        {
            //string olecon = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False; Data Source='" + filename + "';Extended Properties='Excel 8.0;HDR=yes;IMEX=2';";
            string olecon = "Provider=Microsoft.ACE.OLEDB.12.0;Persist Security Info=False; Data Source='" + filename + "';Extended Properties='Excel 12.0;HDR=yes;IMEX=0';";
            string sql1 = "select * from [Sheet1$]";
            string sql2 = "insert into Tzhuanjia(xingming,xingbie,nianling,shenfenzheng,danwei,zhicheng,zhiwu,shouji,dianhua,hangye,zhuanye,leixing,quyu,beizhu) values(@xm,@xb,@nl,@sfz,@dw,@zc,@zw,@sj,@dh,@hy,@zy,@lx,@qy,@bz)";
            OleDbCommand cmd1 = new OleDbCommand(sql1, new OleDbConnection(olecon));
            SqlCommand cmd2 = new SqlCommand(sql2, sub.getcon());
            int i = 0;




            try
            {

                cmd1.Connection.Open();
                cmd2.Connection.Open();
                OleDbDataReader read = cmd1.ExecuteReader();
                while (read.Read())
                {
                    cmd2.Parameters.Clear();

                    cmd2.Parameters.AddWithValue("xm", read[0].ToString());
                    cmd2.Parameters.AddWithValue("xb", read[1].ToString());
                    cmd2.Parameters.AddWithValue("nl", read[2].ToString());
                    cmd2.Parameters.AddWithValue("sfz", read[3].ToString());
                    cmd2.Parameters.AddWithValue("dw", read[4].ToString());
                    cmd2.Parameters.AddWithValue("zc", read[5].ToString());
                    cmd2.Parameters.AddWithValue("zw", read[6].ToString());
                    cmd2.Parameters.AddWithValue("sj", read[7].ToString());
                    cmd2.Parameters.AddWithValue("dh", read[8].ToString());
                    cmd2.Parameters.AddWithValue("hy", read[9].ToString());
                    cmd2.Parameters.AddWithValue("zy", read[10].ToString());
                    cmd2.Parameters.AddWithValue("lx", read[11].ToString());
                    cmd2.Parameters.AddWithValue("qy", read[12].ToString());
                    cmd2.Parameters.AddWithValue("bz", read[13].ToString());
                    cmd2.ExecuteNonQuery();
                    i++;
                }
                cmd1.Connection.Close();
                cmd2.Connection.Close();
            }
            catch
            {
                return 0;
            }
            return i;
        }

        private void 生成导入专家模板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                fs.Write(Properties.Resources.c, 0, Properties.Resources.c.Length);
                fs.Close();
                Process.Start(saveFileDialog1.FileName);
            }
        }

        private void 查看日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flog != null && !flog.IsDisposed)
            {
                flog.WindowState = FormWindowState.Normal;
                flog.Focus();
            }
            else
            {
                flog = new logForm();
                flog.MdiParent = this;
                flog.Show();
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abf = new AboutBox1();
            abf.ShowDialog();
        }

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if(e.Item.Text.Length==0)
            {
                e.Item.Visible = false;
            }
        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regForm regform = new regForm();
            regform.ShowDialog();
        }
    }
}
