namespace StudentLib
{
    partial class TeacherReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvteacher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Report";
            // 
            // dgvteacher
            // 
            this.dgvteacher.AllowUserToAddRows = false;
            this.dgvteacher.AllowUserToDeleteRows = false;
            this.dgvteacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteacher.Location = new System.Drawing.Point(31, 78);
            this.dgvteacher.Name = "dgvteacher";
            this.dgvteacher.RowTemplate.Height = 24;
            this.dgvteacher.Size = new System.Drawing.Size(952, 295);
            this.dgvteacher.TabIndex = 1;
            // 
            // TeacherReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 403);
            this.Controls.Add(this.dgvteacher);
            this.Controls.Add(this.label1);
            this.Name = "TeacherReport";
            this.Text = "TeacherReport";
            this.Load += new System.EventHandler(this.TeacherReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvteacher;
    }
}