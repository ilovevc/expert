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
    public partial class zjlistForm : Form
    {
        public zjlistForm()
        {
            InitializeComponent();
        }

        private void zjlistForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“expertDataSet.Tzhuanjia”中。您可以根据需要移动或删除它。
            this.tzhuanjiaTableAdapter.Fill(this.expertDataSet.Tzhuanjia);
            this.WindowState = FormWindowState.Maximized;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                Form1 f = (Form1)this.MdiParent;
                f.zjlrform.loaddata(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void toolStripButtonref_Click(object sender, EventArgs e)
        {
            tzhuanjiaTableAdapter.Fill(expertDataSet.Tzhuanjia);
        }

        private void toolStripButtondel_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0)
                return;
            if (MessageBox.Show("确实要删除选中项吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            tzhuanjiaTableAdapter.Update(expertDataSet.Tzhuanjia);
            //test
        }
    }
}
