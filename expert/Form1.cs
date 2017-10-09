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

namespace expert
{
    public partial class Form1 : Form
    {
        quyuform fquyu=null;
        zjlrForm fzjlr = null;
        zjlistForm fzjlist = null;
        xmForm2 fxm = null;
        xmlsForm fxmls = null;
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

        }

        private void 导出专家数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private int zjtoexcel(string filename)
        {
            string sql1 = "select * from Tzhuanjia";
            string sql2 = "insert into [$Sheet1] values(@zjid,@xm,@xb,@nl,@sfz,@dw,@zc,@zw,@sj,@dh,@hy,@zy,@lx,@qy,@bz)";
            string olecon = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False; Data Source='" + filename + "';Extended Properties='Excel 8.0;HDR=yes;IMEX=2';";
            SqlCommand cmd1 = new SqlCommand(sql1, sub.getcon());
            OleDbCommand cmd2 = new OleDbCommand(sql2, new OleDbConnection(olecon));
            cmd1.Connection.Open();
            cmd2.Connection.Open();
            SqlDataReader read = cmd1.ExecuteReader();
            while(read.Read())
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("zjid", read["id"].ToString());

            }

            cmd1.Connection.Close();
            cmd2.Connection.Close();
            return 0;
        }
    }
}
