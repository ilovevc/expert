namespace expert
{
    partial class czForm
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
            this.buttonok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(662, 441);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(127, 42);
            this.buttonok.TabIndex = 0;
            this.buttonok.Text = "button1";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // czForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 510);
            this.Controls.Add(this.buttonok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "czForm";
            this.Text = "查找筛选";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonok;
    }
}