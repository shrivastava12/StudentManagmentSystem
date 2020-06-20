namespace StudentLib
{
    partial class frmAddUniform
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
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txttotalcount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtuniformname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbsize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.Classlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbuniformtype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbuniformtype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnsubmit);
            this.groupBox1.Controls.Add(this.txttotalcount);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbcolor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtuniformname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbsize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbclass);
            this.groupBox1.Controls.Add(this.Classlabel);
            this.groupBox1.Location = new System.Drawing.Point(64, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uniform";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(759, 205);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(104, 39);
            this.btnsubmit.TabIndex = 13;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txttotalcount
            // 
            this.txttotalcount.Location = new System.Drawing.Point(501, 162);
            this.txttotalcount.Name = "txttotalcount";
            this.txttotalcount.Size = new System.Drawing.Size(146, 22);
            this.txttotalcount.TabIndex = 12;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(289, 162);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(146, 22);
            this.txtprice.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // cmbcolor
            // 
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Location = new System.Drawing.Point(65, 160);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(149, 24);
            this.cmbcolor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Color";
            // 
            // txtuniformname
            // 
            this.txtuniformname.Location = new System.Drawing.Point(289, 69);
            this.txtuniformname.Name = "txtuniformname";
            this.txtuniformname.Size = new System.Drawing.Size(146, 22);
            this.txtuniformname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "UniformName";
            // 
            // cmbsize
            // 
            this.cmbsize.FormattingEnabled = true;
            this.cmbsize.Location = new System.Drawing.Point(501, 68);
            this.cmbsize.Name = "cmbsize";
            this.cmbsize.Size = new System.Drawing.Size(149, 24);
            this.cmbsize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size";
            // 
            // cmbclass
            // 
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Location = new System.Drawing.Point(65, 68);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(149, 24);
            this.cmbclass.TabIndex = 1;
            // 
            // Classlabel
            // 
            this.Classlabel.AutoSize = true;
            this.Classlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classlabel.Location = new System.Drawing.Point(62, 37);
            this.Classlabel.Name = "Classlabel";
            this.Classlabel.Size = new System.Drawing.Size(52, 20);
            this.Classlabel.TabIndex = 0;
            this.Classlabel.Text = "Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Unform";
            // 
            // cmbuniformtype
            // 
            this.cmbuniformtype.FormattingEnabled = true;
            this.cmbuniformtype.Location = new System.Drawing.Point(729, 68);
            this.cmbuniformtype.Name = "cmbuniformtype";
            this.cmbuniformtype.Size = new System.Drawing.Size(149, 24);
            this.cmbuniformtype.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(725, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Uniform Type";
            // 
            // frmAddUniform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddUniform";
            this.Text = "frmAddUniform";
            this.Load += new System.EventHandler(this.frmAddUniform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbsize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.Label Classlabel;
        private System.Windows.Forms.TextBox txttotalcount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtuniformname;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ComboBox cmbuniformtype;
        private System.Windows.Forms.Label label2;
    }
}