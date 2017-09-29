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
    public partial class xmlsForm : Form
    {
        public xmlsForm()
        {
            InitializeComponent();
        }

        private void xmlsForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“expertDataSetxiangmu.Txiangmu”中。您可以根据需要移动或删除它。
            this.txiangmuTableAdapter.Fill(this.expertDataSetxiangmu.Txiangmu);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.txiangmuTableAdapter.Fill(this.expertDataSetxiangmu.Txiangmu);
        }

        private void 删除项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
                return;

            if (MessageBox.Show("确实要删除选定项目吗？","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                txiangmuTableAdapter.Update(expertDataSetxiangmu.Txiangmu);
            }
        }

        private void 添加排除专家ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
                return;

            pczjForm pczj = new pczjForm(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            pczj.ShowDialog();
        }

        private void 编辑项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0)
                return;
            Form1 f = (Form1)this.MdiParent;
            f.xmform.loaddata(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
