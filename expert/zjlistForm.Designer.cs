namespace expert
{
    partial class zjlistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zjlistForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonref = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtondel = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bianhaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xingmingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xingbieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nianlingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shenfenzhengDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danweiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhichengDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhiwuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoujiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dianhuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhuanyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leixingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tzhuanjiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expertDataSet = new expert.expertDataSet();
            this.tzhuanjiaTableAdapter = new expert.expertDataSetTableAdapters.TzhuanjiaTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzhuanjiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonref,
            this.toolStripButtondel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonref
            // 
            this.toolStripButtonref.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonref.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonref.Image")));
            this.toolStripButtonref.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonref.Name = "toolStripButtonref";
            this.toolStripButtonref.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonref.Text = "刷新";
            this.toolStripButtonref.Click += new System.EventHandler(this.toolStripButtonref_Click);
            // 
            // toolStripButtondel
            // 
            this.toolStripButtondel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtondel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtondel.Image")));
            this.toolStripButtondel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtondel.Name = "toolStripButtondel";
            this.toolStripButtondel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtondel.Text = "删除";
            this.toolStripButtondel.Click += new System.EventHandler(this.toolStripButtondel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bianhaoDataGridViewTextBoxColumn,
            this.xingmingDataGridViewTextBoxColumn,
            this.xingbieDataGridViewTextBoxColumn,
            this.nianlingDataGridViewTextBoxColumn,
            this.shenfenzhengDataGridViewTextBoxColumn,
            this.danweiDataGridViewTextBoxColumn,
            this.zhichengDataGridViewTextBoxColumn,
            this.zhiwuDataGridViewTextBoxColumn,
            this.shoujiDataGridViewTextBoxColumn,
            this.dianhuaDataGridViewTextBoxColumn,
            this.hangyeDataGridViewTextBoxColumn,
            this.zhuanyeDataGridViewTextBoxColumn,
            this.leixingDataGridViewTextBoxColumn,
            this.quyuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tzhuanjiaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(895, 497);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "编号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bianhaoDataGridViewTextBoxColumn
            // 
            this.bianhaoDataGridViewTextBoxColumn.DataPropertyName = "bianhao";
            this.bianhaoDataGridViewTextBoxColumn.HeaderText = "bianhao";
            this.bianhaoDataGridViewTextBoxColumn.Name = "bianhaoDataGridViewTextBoxColumn";
            this.bianhaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.bianhaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // xingmingDataGridViewTextBoxColumn
            // 
            this.xingmingDataGridViewTextBoxColumn.DataPropertyName = "xingming";
            this.xingmingDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.xingmingDataGridViewTextBoxColumn.Name = "xingmingDataGridViewTextBoxColumn";
            this.xingmingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xingbieDataGridViewTextBoxColumn
            // 
            this.xingbieDataGridViewTextBoxColumn.DataPropertyName = "xingbie";
            this.xingbieDataGridViewTextBoxColumn.HeaderText = "性别";
            this.xingbieDataGridViewTextBoxColumn.Name = "xingbieDataGridViewTextBoxColumn";
            this.xingbieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nianlingDataGridViewTextBoxColumn
            // 
            this.nianlingDataGridViewTextBoxColumn.DataPropertyName = "nianling";
            this.nianlingDataGridViewTextBoxColumn.HeaderText = "年龄";
            this.nianlingDataGridViewTextBoxColumn.Name = "nianlingDataGridViewTextBoxColumn";
            this.nianlingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shenfenzhengDataGridViewTextBoxColumn
            // 
            this.shenfenzhengDataGridViewTextBoxColumn.DataPropertyName = "shenfenzheng";
            this.shenfenzhengDataGridViewTextBoxColumn.HeaderText = "身份证号";
            this.shenfenzhengDataGridViewTextBoxColumn.Name = "shenfenzhengDataGridViewTextBoxColumn";
            this.shenfenzhengDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danweiDataGridViewTextBoxColumn
            // 
            this.danweiDataGridViewTextBoxColumn.DataPropertyName = "danwei";
            this.danweiDataGridViewTextBoxColumn.HeaderText = "单位";
            this.danweiDataGridViewTextBoxColumn.Name = "danweiDataGridViewTextBoxColumn";
            this.danweiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zhichengDataGridViewTextBoxColumn
            // 
            this.zhichengDataGridViewTextBoxColumn.DataPropertyName = "zhicheng";
            this.zhichengDataGridViewTextBoxColumn.HeaderText = "职称";
            this.zhichengDataGridViewTextBoxColumn.Name = "zhichengDataGridViewTextBoxColumn";
            this.zhichengDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zhiwuDataGridViewTextBoxColumn
            // 
            this.zhiwuDataGridViewTextBoxColumn.DataPropertyName = "zhiwu";
            this.zhiwuDataGridViewTextBoxColumn.HeaderText = "职务";
            this.zhiwuDataGridViewTextBoxColumn.Name = "zhiwuDataGridViewTextBoxColumn";
            this.zhiwuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shoujiDataGridViewTextBoxColumn
            // 
            this.shoujiDataGridViewTextBoxColumn.DataPropertyName = "shouji";
            this.shoujiDataGridViewTextBoxColumn.HeaderText = "移动电话";
            this.shoujiDataGridViewTextBoxColumn.Name = "shoujiDataGridViewTextBoxColumn";
            this.shoujiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dianhuaDataGridViewTextBoxColumn
            // 
            this.dianhuaDataGridViewTextBoxColumn.DataPropertyName = "dianhua";
            this.dianhuaDataGridViewTextBoxColumn.HeaderText = "固定电话";
            this.dianhuaDataGridViewTextBoxColumn.Name = "dianhuaDataGridViewTextBoxColumn";
            this.dianhuaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hangyeDataGridViewTextBoxColumn
            // 
            this.hangyeDataGridViewTextBoxColumn.DataPropertyName = "hangye";
            this.hangyeDataGridViewTextBoxColumn.HeaderText = "专家行业";
            this.hangyeDataGridViewTextBoxColumn.Name = "hangyeDataGridViewTextBoxColumn";
            this.hangyeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zhuanyeDataGridViewTextBoxColumn
            // 
            this.zhuanyeDataGridViewTextBoxColumn.DataPropertyName = "zhuanye";
            this.zhuanyeDataGridViewTextBoxColumn.HeaderText = "评审专业";
            this.zhuanyeDataGridViewTextBoxColumn.Name = "zhuanyeDataGridViewTextBoxColumn";
            this.zhuanyeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leixingDataGridViewTextBoxColumn
            // 
            this.leixingDataGridViewTextBoxColumn.DataPropertyName = "leixing";
            this.leixingDataGridViewTextBoxColumn.HeaderText = "专家类型";
            this.leixingDataGridViewTextBoxColumn.Name = "leixingDataGridViewTextBoxColumn";
            this.leixingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quyuDataGridViewTextBoxColumn
            // 
            this.quyuDataGridViewTextBoxColumn.DataPropertyName = "quyu";
            this.quyuDataGridViewTextBoxColumn.HeaderText = "所属区域";
            this.quyuDataGridViewTextBoxColumn.Name = "quyuDataGridViewTextBoxColumn";
            this.quyuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tzhuanjiaBindingSource
            // 
            this.tzhuanjiaBindingSource.DataMember = "Tzhuanjia";
            this.tzhuanjiaBindingSource.DataSource = this.expertDataSet;
            // 
            // expertDataSet
            // 
            this.expertDataSet.DataSetName = "expertDataSet";
            this.expertDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tzhuanjiaTableAdapter
            // 
            this.tzhuanjiaTableAdapter.ClearBeforeFill = true;
            // 
            // zjlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "zjlistForm";
            this.Text = "专家列表";
            this.Load += new System.EventHandler(this.zjlistForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzhuanjiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonref;
        private System.Windows.Forms.DataGridView dataGridView1;
        private expertDataSet expertDataSet;
        private System.Windows.Forms.BindingSource tzhuanjiaBindingSource;
        private expertDataSetTableAdapters.TzhuanjiaTableAdapter tzhuanjiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bianhaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xingmingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xingbieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nianlingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shenfenzhengDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danweiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhichengDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhiwuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoujiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dianhuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhuanyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leixingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyuDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButtondel;
    }
}