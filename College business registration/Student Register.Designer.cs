namespace College_business_registration
{
    partial class Student_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Register));
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbocourse = new System.Windows.Forms.ComboBox();
            this.txtTelno = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtproductType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtapprov = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelday = new System.Windows.Forms.Label();
            this.txtday = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnmenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(643, 588);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(59, 37);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please fill in your information.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tel no :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbocourse);
            this.groupBox1.Controls.Add(this.txtTelno);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(32, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 191);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student\'s Info";
            // 
            // cbocourse
            // 
            this.cbocourse.FormattingEnabled = true;
            this.cbocourse.Location = new System.Drawing.Point(84, 108);
            this.cbocourse.Name = "cbocourse";
            this.cbocourse.Size = new System.Drawing.Size(94, 28);
            this.cbocourse.TabIndex = 10;
            // 
            // txtTelno
            // 
            this.txtTelno.Location = new System.Drawing.Point(83, 146);
            this.txtTelno.Name = "txtTelno";
            this.txtTelno.Size = new System.Drawing.Size(154, 26);
            this.txtTelno.TabIndex = 9;
            this.txtTelno.TextChanged += new System.EventHandler(this.txtTelno_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(83, 73);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(153, 26);
            this.txtID.TabIndex = 7;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(83, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(244, 26);
            this.txtname.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtproductType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(32, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product/Service Info";
            // 
            // txtproductType
            // 
            this.txtproductType.Location = new System.Drawing.Point(106, 46);
            this.txtproductType.Name = "txtproductType";
            this.txtproductType.Size = new System.Drawing.Size(195, 26);
            this.txtproductType.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type";
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnregister.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(265, 512);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(104, 41);
            this.btnregister.TabIndex = 9;
            this.btnregister.Text = "REGISTER";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnclear.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(391, 512);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(80, 41);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Type";
            // 
            // cbotype
            // 
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Location = new System.Drawing.Point(76, 34);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(144, 28);
            this.cbotype.TabIndex = 9;
            this.cbotype.SelectedIndexChanged += new System.EventHandler(this.cbotype_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtapprov);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.labelday);
            this.groupBox3.Controls.Add(this.txtday);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtfee);
            this.groupBox3.Controls.Add(this.btncalc);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbotype);
            this.groupBox3.Location = new System.Drawing.Point(407, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 324);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Business";
            // 
            // txtapprov
            // 
            this.txtapprov.Location = new System.Drawing.Point(112, 273);
            this.txtapprov.Name = "txtapprov";
            this.txtapprov.Size = new System.Drawing.Size(136, 26);
            this.txtapprov.TabIndex = 22;
            this.txtapprov.TextChanged += new System.EventHandler(this.txtapprov_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Approval";
            // 
            // labelday
            // 
            this.labelday.AutoSize = true;
            this.labelday.Location = new System.Drawing.Point(47, 117);
            this.labelday.Name = "labelday";
            this.labelday.Size = new System.Drawing.Size(45, 20);
            this.labelday.TabIndex = 20;
            this.labelday.Text = "Days";
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(112, 114);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(74, 26);
            this.txtday.TabIndex = 19;
            this.txtday.TextChanged += new System.EventHandler(this.txtday_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fee (RM)";
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(112, 229);
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(83, 26);
            this.txtfee.TabIndex = 13;
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btncalc.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(96, 154);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(113, 41);
            this.btncalc.TabIndex = 12;
            this.btncalc.Text = "CALCULATE";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Duration of business";
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.Location = new System.Drawing.Point(565, 589);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(72, 37);
            this.btnmenu.TabIndex = 16;
            this.btnmenu.Text = "MENU";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnhelp.ForeColor = System.Drawing.Color.White;
            this.btnhelp.Location = new System.Drawing.Point(29, 588);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(72, 38);
            this.btnhelp.TabIndex = 18;
            this.btnhelp.Text = "HELP";
            this.btnhelp.UseVisualStyleBackColor = false;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // Student_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(720, 639);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Student_Register";
            this.Text = "STUDENT REGISTRATION FORM";
            this.Load += new System.EventHandler(this.Student_Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelno;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbotype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtproductType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelday;
        private System.Windows.Forms.TextBox txtday;
        private System.Windows.Forms.ComboBox cbocourse;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.TextBox txtapprov;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnhelp;
    }
}