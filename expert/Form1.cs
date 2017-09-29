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

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zjselForm zjsel = new zjselForm();
            if(zjsel.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(zjsel.zjid);
            }
        }

       
    }
}
