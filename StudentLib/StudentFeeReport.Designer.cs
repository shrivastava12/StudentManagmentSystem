namespace StudentLib
{
    partial class StudentFeeReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.grdstudentfee = new System.Windows.Forms.DataGridView();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnsearchbyname = new System.Windows.Forms.Button();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdstudentfee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Fee Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // grdstudentfee
            // 
            this.grdstudentfee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdstudentfee.Location = new System.Drawing.Point(323, 80);
            this.grdstudentfee.Name = "grdstudentfee";
            this.grdstudentfee.RowTemplate.Height = 24;
            this.grdstudentfee.Size = new System.Drawing.Size(929, 294);
            this.grdstudentfee.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(41, 91);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(193, 22);
            this.txtname.TabIndex = 3;
            // 
            // btnsearchbyname
            // 
            this.btnsearchbyname.Location = new System.Drawing.Point(118, 135);
            this.btnsearchbyname.Name = "btnsearchbyname";
            this.btnsearchbyname.Size = new System.Drawing.Size(116, 34);
            this.btnsearchbyname.TabIndex = 4;
            this.btnsearchbyname.Text = "search";
            this.btnsearchbyname.UseVisualStyleBackColor = true;
            this.btnsearchbyname.Click += new System.EventHandler(this.btnsearchbyname_Click);
            // 
            // cmbclass
            // 
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Location = new System.Drawing.Point(41, 233);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(193, 24);
            this.cmbclass.TabIndex = 5;
            this.cmbclass.SelectedIndexChanged += new System.EventHandler(this.cmbclass_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(1136, 396);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(116, 34);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // StudentFeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 452);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbclass);
            this.Controls.Add(this.btnsearchbyname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.grdstudentfee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentFeeReport";
            this.Text = "StudentFeeReport";
            this.Load += new System.EventHandler(this.StudentFeeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdstudentfee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdstudentfee;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnsearchbyname;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reset;
    }
}