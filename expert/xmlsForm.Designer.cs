﻿namespace expert
{
    partial class xmlsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xmlsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zbjgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加排除专家ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txiangmuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expertDataSetxiangmu = new expert.expertDataSetxiangmu();
            this.txiangmuTableAdapter = new expert.expertDataSetxiangmuTableAdapters.TxiangmuTableAdapter();
            this.抽取项目专家ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txiangmuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertDataSetxiangmu)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(832, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "刷新";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.mcDataGridViewTextBoxColumn,
            this.rqDataGridViewTextBoxColumn,
            this.sjDataGridViewTextBoxColumn,
            this.ddDataGridViewTextBoxColumn,
            this.zbjgDataGridViewTextBoxColumn,
            this.qyDataGridViewTextBoxColumn,
            this.lxDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.txiangmuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(832, 407);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "项目编号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mcDataGridViewTextBoxColumn
            // 
            this.mcDataGridViewTextBoxColumn.DataPropertyName = "mc";
            this.mcDataGridViewTextBoxColumn.HeaderText = "项目名称";
            this.mcDataGridViewTextBoxColumn.Name = "mcDataGridViewTextBoxColumn";
            this.mcDataGridViewTextBoxColumn.ReadOnly = true;
            this.mcDataGridViewTextBoxColumn.Width = 300;
            // 
            // rqDataGridViewTextBoxColumn
            // 
            this.rqDataGridViewTextBoxColumn.DataPropertyName = "rq";
            this.rqDataGridViewTextBoxColumn.HeaderText = "评标日期";
            this.rqDataGridViewTextBoxColumn.Name = "rqDataGridViewTextBoxColumn";
            this.rqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sjDataGridViewTextBoxColumn
            // 
            this.sjDataGridViewTextBoxColumn.DataPropertyName = "sj";
            this.sjDataGridViewTextBoxColumn.HeaderText = "评标时间";
            this.sjDataGridViewTextBoxColumn.Name = "sjDataGridViewTextBoxColumn";
            this.sjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ddDataGridViewTextBoxColumn
            // 
            this.ddDataGridViewTextBoxColumn.DataPropertyName = "dd";
            this.ddDataGridViewTextBoxColumn.HeaderText = "评标地点";
            this.ddDataGridViewTextBoxColumn.Name = "ddDataGridViewTextBoxColumn";
            this.ddDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zbjgDataGridViewTextBoxColumn
            // 
            this.zbjgDataGridViewTextBoxColumn.DataPropertyName = "zbjg";
            this.zbjgDataGridViewTextBoxColumn.HeaderText = "招标机构（人）";
            this.zbjgDataGridViewTextBoxColumn.Name = "zbjgDataGridViewTextBoxColumn";
            this.zbjgDataGridViewTextBoxColumn.ReadOnly = true;
            this.zbjgDataGridViewTextBoxColumn.Width = 150;
            // 
            // qyDataGridViewTextBoxColumn
            // 
            this.qyDataGridViewTextBoxColumn.DataPropertyName = "qy";
            this.qyDataGridViewTextBoxColumn.HeaderText = "所属区域";
            this.qyDataGridViewTextBoxColumn.Name = "qyDataGridViewTextBoxColumn";
            this.qyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lxDataGridViewTextBoxColumn
            // 
            this.lxDataGridViewTextBoxColumn.DataPropertyName = "lx";
            this.lxDataGridViewTextBoxColumn.HeaderText = "项目类型";
            this.lxDataGridViewTextBoxColumn.Name = "lxDataGridViewTextBoxColumn";
            this.lxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除项目ToolStripMenuItem,
            this.添加排除专家ToolStripMenuItem,
            this.编辑项目ToolStripMenuItem,
            this.抽取项目专家ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 114);
            // 
            // 删除项目ToolStripMenuItem
            // 
            this.删除项目ToolStripMenuItem.Name = "删除项目ToolStripMenuItem";
            this.删除项目ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.删除项目ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.删除项目ToolStripMenuItem.Text = "删除项目";
            this.删除项目ToolStripMenuItem.Click += new System.EventHandler(this.删除项目ToolStripMenuItem_Click);
            // 
            // 添加排除专家ToolStripMenuItem
            // 
            this.添加排除专家ToolStripMenuItem.Name = "添加排除专家ToolStripMenuItem";
            this.添加排除专家ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.添加排除专家ToolStripMenuItem.Text = "项目排除专家...";
            this.添加排除专家ToolStripMenuItem.Click += new System.EventHandler(this.添加排除专家ToolStripMenuItem_Click);
            // 
            // 编辑项目ToolStripMenuItem
            // 
            this.编辑项目ToolStripMenuItem.Name = "编辑项目ToolStripMenuItem";
            this.编辑项目ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.编辑项目ToolStripMenuItem.Text = "编辑项目...";
            this.编辑项目ToolStripMenuItem.Click += new System.EventHandler(this.编辑项目ToolStripMenuItem_Click);
            // 
            // txiangmuBindingSource
            // 
            this.txiangmuBindingSource.DataMember = "Txiangmu";
            this.txiangmuBindingSource.DataSource = this.expertDataSetxiangmu;
            // 
            // expertDataSetxiangmu
            // 
            this.expertDataSetxiangmu.DataSetName = "expertDataSetxiangmu";
            this.expertDataSetxiangmu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txiangmuTableAdapter
            // 
            this.txiangmuTableAdapter.ClearBeforeFill = true;
            // 
            // 抽取项目专家ToolStripMenuItem
            // 
            this.抽取项目专家ToolStripMenuItem.Name = "抽取项目专家ToolStripMenuItem";
            this.抽取项目专家ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.抽取项目专家ToolStripMenuItem.Text = "抽取项目专家...";
            this.抽取项目专家ToolStripMenuItem.Click += new System.EventHandler(this.抽取项目专家ToolStripMenuItem_Click);
            // 
            // xmlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "xmlsForm";
            this.ShowIcon = false;
            this.Text = "项目列表";
            this.Load += new System.EventHandler(this.xmlsForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txiangmuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertDataSetxiangmu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private expertDataSetxiangmu expertDataSetxiangmu;
        private System.Windows.Forms.BindingSource txiangmuBindingSource;
        private expertDataSetxiangmuTableAdapters.TxiangmuTableAdapter txiangmuTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除项目ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zbjgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lxDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 添加排除专家ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 抽取项目专家ToolStripMenuItem;
    }
}