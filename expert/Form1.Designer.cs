﻿namespace expert
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.区域信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.专家信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专家列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.项目信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolmsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.导出专家数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出专家数据ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
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
            this.项目列表ToolStripMenuItem,
            this.toolStripSeparator3});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 区域信息录入ToolStripMenuItem
            // 
            this.区域信息录入ToolStripMenuItem.Name = "区域信息录入ToolStripMenuItem";
            this.区域信息录入ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.区域信息录入ToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.区域信息录入ToolStripMenuItem.Text = "区域信息管理";
            this.区域信息录入ToolStripMenuItem.Click += new System.EventHandler(this.区域信息录入ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // 专家信息录入ToolStripMenuItem
            // 
            this.专家信息录入ToolStripMenuItem.Name = "专家信息录入ToolStripMenuItem";
            this.专家信息录入ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.专家信息录入ToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.专家信息录入ToolStripMenuItem.Text = "专家信息录入";
            this.专家信息录入ToolStripMenuItem.Click += new System.EventHandler(this.专家信息录入ToolStripMenuItem_Click);
            // 
            // 专家列表ToolStripMenuItem
            // 
            this.专家列表ToolStripMenuItem.Name = "专家列表ToolStripMenuItem";
            this.专家列表ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.专家列表ToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.专家列表ToolStripMenuItem.Text = "专家列表";
            this.专家列表ToolStripMenuItem.Click += new System.EventHandler(this.专家列表ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // 项目信息录入ToolStripMenuItem
            // 
            this.项目信息录入ToolStripMenuItem.Name = "项目信息录入ToolStripMenuItem";
            this.项目信息录入ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.项目信息录入ToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.项目信息录入ToolStripMenuItem.Text = "项目信息录入";
            this.项目信息录入ToolStripMenuItem.Click += new System.EventHandler(this.项目信息录入ToolStripMenuItem_Click);
            // 
            // 项目列表ToolStripMenuItem
            // 
            this.项目列表ToolStripMenuItem.Name = "项目列表ToolStripMenuItem";
            this.项目列表ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.项目列表ToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.项目列表ToolStripMenuItem.Text = "项目列表";
            this.项目列表ToolStripMenuItem.Click += new System.EventHandler(this.项目列表ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(224, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolmsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(958, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolmsg
            // 
            this.toolmsg.Name = "toolmsg";
            this.toolmsg.Size = new System.Drawing.Size(32, 17);
            this.toolmsg.Text = "就绪";
            // 
            // 导出专家数据ToolStripMenuItem
            // 
            this.导出专家数据ToolStripMenuItem.Name = "导出专家数据ToolStripMenuItem";
            this.导出专家数据ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.导出专家数据ToolStripMenuItem.Text = "导出专家数据...";
            this.导出专家数据ToolStripMenuItem.Click += new System.EventHandler(this.导出专家数据ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 526);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 导出专家数据ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

