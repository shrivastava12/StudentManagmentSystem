namespace StudentLib
{
    partial class frmStudent
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
            this.dtpadmissiondate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbsectionid = new System.Windows.Forms.ComboBox();
            this.cmbclassid = new System.Windows.Forms.ComboBox();
            this.dtpdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmothersname = new System.Windows.Forms.TextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfathersname = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpadmissiondate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbsectionid);
            this.groupBox1.Controls.Add(this.cmbclassid);
            this.groupBox1.Controls.Add(this.dtpdateofbirth);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtphoneno);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtmothersname);
            this.groupBox1.Controls.Add(this.cmbgender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfathersname);
            this.groupBox1.Controls.Add(this.btnsubmit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // dtpadmissiondate
            // 
            this.dtpadmissiondate.Location = new System.Drawing.Point(537, 266);
            this.dtpadmissiondate.Name = "dtpadmissiondate";
            this.dtpadmissiondate.Size = new System.Drawing.Size(200, 22);
            this.dtpadmissiondate.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Admission Date";
            // 
            // cmbsectionid
            // 
            this.cmbsectionid.FormattingEnabled = true;
            this.cmbsectionid.Location = new System.Drawing.Point(272, 266);
            this.cmbsectionid.Name = "cmbsectionid";
            this.cmbsectionid.Size = new System.Drawing.Size(193, 24);
            this.cmbsectionid.TabIndex = 26;
            this.cmbsectionid.SelectedIndexChanged += new System.EventHandler(this.cmbsectionid_SelectedIndexChanged);
            // 
            // cmbclassid
            // 
            this.cmbclassid.FormattingEnabled = true;
            this.cmbclassid.Location = new System.Drawing.Point(48, 266);
            this.cmbclassid.Name = "cmbclassid";
            this.cmbclassid.Size = new System.Drawing.Size(193, 24);
            this.cmbclassid.TabIndex = 25;
            // 
            // dtpdateofbirth
            // 
            this.dtpdateofbirth.Location = new System.Drawing.Point(273, 197);
            this.dtpdateofbirth.Name = "dtpdateofbirth";
            this.dtpdateofbirth.Size = new System.Drawing.Size(200, 22);
            this.dtpdateofbirth.TabIndex = 24;
            this.dtpdateofbirth.ValueChanged += new System.EventHandler(this.dtpdateofbirth_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Phone No";
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(534, 117);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(192, 22);
            this.txtphoneno.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(273, 117);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(192, 22);
            this.txtemail.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Age(in months)";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(49, 117);
            this.txtage.Name = "txtage";
            this.txtage.ReadOnly = true;
            this.txtage.Size = new System.Drawing.Size(192, 22);
            this.txtage.TabIndex = 18;
            this.txtage.Text = "d";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mother\'s Name";
            // 
            // txtmothersname
            // 
            this.txtmothersname.Location = new System.Drawing.Point(533, 55);
            this.txtmothersname.Name = "txtmothersname";
            this.txtmothersname.Size = new System.Drawing.Size(202, 22);
            this.txtmothersname.TabIndex = 16;
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Location = new System.Drawing.Point(49, 196);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(192, 24);
            this.cmbgender.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Select Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(533, 196);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(192, 22);
            this.txtaddress.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Father\'s Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtfathersname
            // 
            this.txtfathersname.Location = new System.Drawing.Point(272, 55);
            this.txtfathersname.Name = "txtfathersname";
            this.txtfathersname.Size = new System.Drawing.Size(224, 22);
            this.txtfathersname.TabIndex = 3;
            this.txtfathersname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(49, 334);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(106, 35);
            this.btnsubmit.TabIndex = 2;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(49, 55);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(192, 22);
            this.txtname.TabIndex = 0;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 569);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfathersname;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmothersname;
        private System.Windows.Forms.DateTimePicker dtpdateofbirth;
        private System.Windows.Forms.DateTimePicker dtpadmissiondate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbsectionid;
        private System.Windows.Forms.ComboBox cmbclassid;
    }
}