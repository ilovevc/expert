namespace expert
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出专家数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入专家数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成导入专家模板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.区域信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.专家信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专家列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.项目信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolmsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.设置SToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1916, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.menuStrip1_ItemAdded);
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出专家数据ToolStripMenuItem,
            this.导入专家数据ToolStripMenuItem,
            this.生成导入专家模板ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(103, 38);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 导出专家数据ToolStripMenuItem
            // 
            this.导出专家数据ToolStripMenuItem.Name = "导出专家数据ToolStripMenuItem";
            this.导出专家数据ToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.导出专家数据ToolStripMenuItem.Text = "导出专家数据...";
            this.导出专家数据ToolStripMenuItem.Click += new System.EventHandler(this.导出专家数据ToolStripMenuItem_Click);
            // 
            // 导入专家数据ToolStripMenuItem
            // 
            this.导入专家数据ToolStripMenuItem.Name = "导入专家数据ToolStripMenuItem";
            this.导入专家数据ToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.导入专家数据ToolStripMenuItem.Text = "导入专家数据...";
            this.导入专家数据ToolStripMenuItem.Click += new System.EventHandler(this.导入专家数据ToolStripMenuItem_Click);
            // 
            // 生成导入专家模板ToolStripMenuItem
            // 
            this.生成导入专家模板ToolStripMenuItem.Name = "生成导入专家模板ToolStripMenuItem";
            this.生成导入专家模板ToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.生成导入专家模板ToolStripMenuItem.Text = "生成导入专家模板...";
            this.生成导入专家模板ToolStripMenuItem.Click += new System.EventHandler(this.生成导入专家模板ToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.区域信息录入ToolStripMenuItem,
            this.toolStripSeparator1,
            this.专家信息录入ToolStripMenuItem,
            this.专家列表ToolStripMenuItem,
            this.toolStripSeparator2,
            this.项目信息录入ToolStripMenuItem,
            this.项目列表ToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(103, 38);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 区域信息录入ToolStripMenuItem
            // 
            this.区域信息录入ToolStripMenuItem.Name = "区域信息录入ToolStripMenuItem";
            this.区域信息录入ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.区域信息录入ToolStripMenuItem.Size = new System.Drawing.Size(413, 38);
            this.区域信息录入ToolStripMenuItem.Text = "区域信息管理";
            this.区域信息录入ToolStripMenuItem.Click += new System.EventHandler(this.区域信息录入ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(410, 6);
            // 
            // 专家信息录入ToolStripMenuItem
            // 
            this.专家信息录入ToolStripMenuItem.Name = "专家信息录入ToolStripMenuItem";
            this.专家信息录入ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.专家信息录入ToolStripMenuItem.Size = new System.Drawing.Size(413, 38);
            this.专家信息录入ToolStripMenuItem.Text = "专家信息录入";
            this.专家信息录入ToolStripMenuItem.Click += new System.EventHandler(this.专家信息录入ToolStripMenuItem_Click);
            // 
            // 专家列表ToolStripMenuItem
            // 
            this.专家列表ToolStripMenuItem.Name = "专家列表ToolStripMenuItem";
            this.专家列表ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.专家列表ToolStripMenuItem.Size = new System.Drawing.Size(413, 38);
            this.专家列表ToolStripMenuItem.Text = "专家列表";
            this.专家列表ToolStripMenuItem.Click += new System.EventHandler(this.专家列表ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(410, 6);
            // 
            // 项目信息录入ToolStripMenuItem
            // 
            this.项目信息录入ToolStripMenuItem.Name = "项目信息录入ToolStripMenuItem";
            this.项目信息录入ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.项目信息录入ToolStripMenuItem.Size = new System.Drawing.Size(413, 38);
            this.项目信息录入ToolStripMenuItem.Text = "项目信息录入";
            this.项目信息录入ToolStripMenuItem.Click += new System.EventHandler(this.项目信息录入ToolStripMenuItem_Click);
            // 
            // 项目列表ToolStripMenuItem
            // 
            this.项目列表ToolStripMenuItem.Name = "项目列表ToolStripMenuItem";
            this.项目列表ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.项目列表ToolStripMenuItem.Size = new System.Drawing.Size(413, 38);
            this.项目列表ToolStripMenuItem.Text = "项目列表";
            this.项目列表ToolStripMenuItem.Click += new System.EventHandler(this.项目列表ToolStripMenuItem_Click);
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看日志ToolStripMenuItem});
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(104, 38);
            this.设置SToolStripMenuItem.Text = "设置(&S)";
            // 
            // 查看日志ToolStripMenuItem
            // 
            this.查看日志ToolStripMenuItem.Name = "查看日志ToolStripMenuItem";
            this.查看日志ToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.查看日志ToolStripMenuItem.Text = "查看日志...";
            this.查看日志ToolStripMenuItem.Click += new System.EventHandler(this.查看日志ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(109, 38);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            this.帮助HToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.关于ToolStripMenuItem.Text = "关于本软件...";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolmsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1016);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1916, 36);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolmsg
            // 
            this.toolmsg.Name = "toolmsg";
            this.toolmsg.Size = new System.Drawing.Size(62, 31);
            this.toolmsg.Text = "就绪";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "专家信息表";
            this.saveFileDialog1.Filter = "电子表格|*.xls";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "电子表格|*.xls";
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.注册ToolStripMenuItem.Text = "注册...";
            this.注册ToolStripMenuItem.Click += new System.EventHandler(this.注册ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1052);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "专家抽取系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 区域信息录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 专家信息录入ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolmsg;
        private System.Windows.Forms.ToolStripMenuItem 专家列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目信息录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 项目列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出专家数据ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 导入专家数据ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 生成导入专家模板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;
    }
}

