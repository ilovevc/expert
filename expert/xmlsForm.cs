using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

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
            this.WindowState = FormWindowState.Maximized;
            

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

                string xm = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                txiangmuTableAdapter.Update(expertDataSetxiangmu.Txiangmu);
                sub.writelog("删除项目" + xm);
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

        private void 抽取项目专家ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
                return;
            cqForm cq = new cqForm(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            cq.ShowDialog();
        }

        private void listdata(string str="")
        {
            string sql;
            if (str == "")
            {
                sql = "select * from Txiangmu";

            }
            else
            {

                Regex regex = new Regex(@"^[0-9]+$");
                if (regex.IsMatch(str))
                {
                    sql = "select * from Txiangmu where id='" + str + "'";
                }
                else
                {

                    sql = "select * from Txiangmu where mc like '%" + str + "%'";
                }
            }

            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void scrtoolStripButton_Click(object sender, EventArgs e)
        {
            if (scrTextBox.Text == "输入编号或关键字查找")
                listdata();
            else
                listdata(scrTextBox.Text);
        }

        private void scrTextBox_Enter(object sender, EventArgs e)
        {
            if (scrTextBox.Text == "输入编号或关键字查找")
                scrTextBox.Text = "";
        }

        private void scrTextBox_Leave(object sender, EventArgs e)
        {
            if (scrTextBox.Text == "")
                scrTextBox.Text = "输入编号或关键字查找";
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Form1 f1 = this.MdiParent as Form1;
            f1.xmform.Show();
        }
    }
}
