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
    public partial class regForm : Form
    {
        public regForm()
        {
            InitializeComponent();
        }

        private void regForm_Load(object sender, EventArgs e)
        {
            textBoxid.Text = sub.getcupid();
            textBoxkey.Text = sub.readregkey();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxkey.Text == sub.getKEY())
            {
                sub.writeregkey(textBoxkey.Text);
                MessageBox.Show("软件注册成功！请重启软件完成注册。");
                this.Close();
            }
            else
            {
                MessageBox.Show("注册码不正确，请重新输入。");
            }
        }
    }
}
