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
            //tzhuanjiaTableAdapter.Fill(expertDataSet.Tzhuanjia);
            listdata();
        }

        private void toolStripButtondel_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0)
                return;
            if (MessageBox.Show("确实要删除选中项吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            /*
            string sql = "delete from Tzhuanjia where id=@id";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            string xm = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cmd.Parameters.AddWithValue("id", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            listdata();
            sub.writelog("删除专家" + xm);*/
            //tzhuanjiaTableAdapter.Update(expertDataSet.Tzhuanjia);
            //test
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                delzj(row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
            }
            listdata();
        }

        private bool delzj(string id,string xm)
        {

            string sql = "delete from Tzhuanjia where id=@id";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            
            cmd.Parameters.AddWithValue("id", id);
            cmd.Connection.Open();
            int i=cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            
            sub.writelog("删除专家" + xm);

            if (i > 0)
                return true;
            else
                return false;
        }

        private void toolStripButtonfind_Click(object sender, EventArgs e)
        {
            /* czForm formcz = new czForm();
             if(formcz.ShowDialog ()==DialogResult.OK)
             {
                 MessageBox.Show("ok");
             }*/

            if (scrTextBox1.Text == "输入姓名或编号查找")
                listdata();
            else
                listdata(scrTextBox1.Text);
        }

        private void listdata(string str="")
        {
            string sql;
            if (str == "")
            {
                sql = "select * from Tzhuanjia";

            }
            else
            {

                Regex regex = new Regex(@"^[0-9]+$");
                if (regex.IsMatch(str))
                {
                    sql = "select * from Tzhuanjia where id='" + str + "'";
                }
                else
                {
                    
                    sql = "select * from Tzhuanjia where xingming='" + str + "'";
                }
            }

            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void scrTextBox1_Enter(object sender, EventArgs e)
        {
            if (scrTextBox1.Text == "输入姓名或编号查找")
                scrTextBox1.Text = "";
        }

        private void scrTextBox1_Leave(object sender, EventArgs e)
        {
            if (scrTextBox1.Text == "")
                scrTextBox1.Text = "输入姓名或编号查找";
        }
    }
}
