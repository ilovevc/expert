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

namespace expert
{
    public partial class quyuform : Form
    {
        public quyuform()
        {
            InitializeComponent();
        }

        private void quyuform_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            listquyu.Items.Clear();

            string sql = "select * from Tdizhi";
            SqlCommand cmd = new SqlCommand(sql, sub.getcon());
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                listquyu.Items.Add(reader["dizhi"].ToString());
            }
            cmd.Connection.Close();
        }

        private void toolStripButtonadd_Click(object sender, EventArgs e)
        {
            if(TextBoxdizhi.Text.Trim()!="")
            {
                string sql = "insert into Tdizhi(dizhi) values(@dizhi)";
                //SqlParameter parameterdizhi = new SqlParameter("dizhi", TextBoxdizhi.Text);
                SqlCommand cmd = new SqlCommand(sql, sub.getcon());
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("dizhi", TextBoxdizhi.Text.Trim());
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                TextBoxdizhi.Text = "";
                loaddata();
            }
        }

        private void toolStripButtondel_Click(object sender, EventArgs e)
        {
            if(listquyu.SelectedItems.Count>0)
            {
                string sql = "delete Tdizhi where dizhi=@dizhi";
                SqlCommand cmd = new SqlCommand(sql, sub.getcon());
                cmd.Parameters.AddWithValue("dizhi", listquyu.Text);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                loaddata();
            }
        }
    }
}
