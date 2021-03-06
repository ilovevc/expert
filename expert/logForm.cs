﻿using System;
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
    public partial class logForm : Form
    {
        public logForm()
        {
            InitializeComponent();
        }

        private void logForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“expertDataSetlog.log”中。您可以根据需要移动或删除它。
            this.logTableAdapter.Fill(this.expertDataSetlog.log);
            this.WindowState = FormWindowState.Maximized;
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.logTableAdapter.Fill(this.expertDataSetlog.log);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.logTableAdapter.FillBy(this.expertDataSetlog.log);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
