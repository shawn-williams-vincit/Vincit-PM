namespace Vincit.PM
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVJobs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVJobs
            // 
            this.DGVJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVJobs.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVJobs.Location = new System.Drawing.Point(0, 0);
            this.DGVJobs.Name = "DGVJobs";
            this.DGVJobs.RowHeadersWidth = 51;
            this.DGVJobs.RowTemplate.Height = 29;
            this.DGVJobs.Size = new System.Drawing.Size(1806, 112);
            this.DGVJobs.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 838);
            this.Controls.Add(this.DGVJobs);
            this.Name = "MainForm";
            this.Text = "Jobs";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGVJobs;
    }
}