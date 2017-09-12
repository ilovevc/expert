namespace expert
{
    partial class quyuform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quyuform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TextBoxdizhi = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonadd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtondel = new System.Windows.Forms.ToolStripButton();
            this.listquyu = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBoxdizhi,
            this.toolStripButtonadd,
            this.toolStripButtondel});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(215, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TextBoxdizhi
            // 
            this.TextBoxdizhi.Name = "TextBoxdizhi";
            this.TextBoxdizhi.Size = new System.Drawing.Size(82, 25);
            // 
            // toolStripButtonadd
            // 
            this.toolStripButtonadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonadd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonadd.Image")));
            this.toolStripButtonadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonadd.Name = "toolStripButtonadd";
            this.toolStripButtonadd.Size = new System.Drawing.Size(36, 22);
            this.toolStripButtonadd.Text = "添加";
            this.toolStripButtonadd.Click += new System.EventHandler(this.toolStripButtonadd_Click);
            // 
            // toolStripButtondel
            // 
            this.toolStripButtondel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtondel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtondel.Image")));
            this.toolStripButtondel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtondel.Name = "toolStripButtondel";
            this.toolStripButtondel.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtondel.Text = "删除选中项";
            this.toolStripButtondel.Click += new System.EventHandler(this.toolStripButtondel_Click);
            // 
            // listquyu
            // 
            this.listquyu.Font = new System.Drawing.Font("宋体", 12F);
            this.listquyu.FormattingEnabled = true;
            this.listquyu.ItemHeight = 16;
            this.listquyu.Location = new System.Drawing.Point(0, 28);
            this.listquyu.Name = "listquyu";
            this.listquyu.Size = new System.Drawing.Size(215, 228);
            this.listquyu.TabIndex = 1;
            // 
            // quyuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(215, 256);
            this.Controls.Add(this.listquyu);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.Name = "quyuform";
            this.ShowIcon = false;
            this.Text = "区域信息管理";
            this.Load += new System.EventHandler(this.quyuform_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox TextBoxdizhi;
        private System.Windows.Forms.ToolStripButton toolStripButtonadd;
        private System.Windows.Forms.ToolStripButton toolStripButtondel;
        private System.Windows.Forms.ListBox listquyu;
    }
}