using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expert
{
    public partial class Form1 : Form
    {
        quyuform fquyu=null;
        zjlrForm fzjlr = null;
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
    }
}
