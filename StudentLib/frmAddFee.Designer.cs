namespace StudentLib
{
    partial class frmAddFee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdueamount = new System.Windows.Forms.TextBox();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.txttotalfee = new System.Windows.Forms.TextBox();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtppayment = new System.Windows.Forms.DateTimePicker();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbstudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdueamount);
            this.groupBox1.Controls.Add(this.txtpaidamount);
            this.groupBox1.Controls.Add(this.txttotalfee);
            this.groupBox1.Controls.Add(this.cmbclass);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtppayment);
            this.groupBox1.Controls.Add(this.btnsubmit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbmonth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbstudent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fee ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtdueamount
            // 
            this.txtdueamount.Location = new System.Drawing.Point(616, 140);
            this.txtdueamount.Name = "txtdueamount";
            this.txtdueamount.Size = new System.Drawing.Size(194, 22);
            this.txtdueamount.TabIndex = 19;
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Location = new System.Drawing.Point(311, 140);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(194, 22);
            this.txtpaidamount.TabIndex = 18;
            this.txtpaidamount.TextChanged += new System.EventHandler(this.txtpaidamount_TextChanged);
            // 
            // txttotalfee
            // 
            this.txttotalfee.Location = new System.Drawing.Point(40, 140);
            this.txttotalfee.Name = "txttotalfee";
            this.txttotalfee.Size = new System.Drawing.Size(194, 22);
            this.txttotalfee.TabIndex = 17;
            // 
            // cmbclass
            // 
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Location = new System.Drawing.Point(40, 62);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(194, 24);
            this.cmbclass.TabIndex = 16;
            this.cmbclass.SelectedIndexChanged += new System.EventHandler(this.cmbclass_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date of Payment";
            // 
            // dtppayment
            // 
            this.dtppayment.Location = new System.Drawing.Point(40, 220);
            this.dtppayment.Name = "dtppayment";
            this.dtppayment.Size = new System.Drawing.Size(200, 22);
            this.dtppayment.TabIndex = 14;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(676, 218);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(134, 31);
            this.btnsubmit.TabIndex = 13;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Due Amount";
            // 
            // cmbmonth
            // 
            this.cmbmonth.FormattingEnabled = true;
            this.cmbmonth.Location = new System.Drawing.Point(616, 55);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(194, 24);
            this.cmbmonth.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Paid Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Fee";
            // 
            // cmbstudent
            // 
            this.cmbstudent.FormattingEnabled = true;
            this.cmbstudent.Location = new System.Drawing.Point(311, 62);
            this.cmbstudent.Name = "cmbstudent";
            this.cmbstudent.Size = new System.Drawing.Size(194, 24);
            this.cmbstudent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Class";
            // 
            // frmAddFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 330);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddFee";
            this.Text = "frmAddFee";
            this.Load += new System.EventHandler(this.frmAddFee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbstudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtppayment;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.TextBox txtdueamount;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.TextBox txttotalfee;
    }
}