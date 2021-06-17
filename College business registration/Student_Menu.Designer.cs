namespace College_business_registration
{
    partial class Student_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Menu));
            this.btnregister = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnstatus = new System.Windows.Forms.Button();
            this.btnmainmenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.Salmon;
            this.btnregister.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Location = new System.Drawing.Point(159, 253);
            this.btnregister.Margin = new System.Windows.Forms.Padding(4);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(224, 61);
            this.btnregister.TabIndex = 0;
            this.btnregister.Text = "REGISTER";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(452, 476);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(73, 44);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnstatus
            // 
            this.btnstatus.BackColor = System.Drawing.Color.Salmon;
            this.btnstatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstatus.ForeColor = System.Drawing.Color.White;
            this.btnstatus.Location = new System.Drawing.Point(159, 331);
            this.btnstatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnstatus.Name = "btnstatus";
            this.btnstatus.Size = new System.Drawing.Size(224, 60);
            this.btnstatus.TabIndex = 7;
            this.btnstatus.Text = "APPROVAL STATUS";
            this.btnstatus.UseVisualStyleBackColor = false;
            this.btnstatus.Click += new System.EventHandler(this.btnstatus_Click);
            // 
            // btnmainmenu
            // 
            this.btnmainmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnmainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmainmenu.ForeColor = System.Drawing.Color.White;
            this.btnmainmenu.Location = new System.Drawing.Point(371, 476);
            this.btnmainmenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnmainmenu.Name = "btnmainmenu";
            this.btnmainmenu.Size = new System.Drawing.Size(73, 44);
            this.btnmainmenu.TabIndex = 8;
            this.btnmainmenu.Text = "BACK";
            this.btnmainmenu.UseVisualStyleBackColor = false;
            this.btnmainmenu.Click += new System.EventHandler(this.btnmainmenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "STUDENT";
            // 
            // Student_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(542, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmainmenu);
            this.Controls.Add(this.btnstatus);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnregister);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Student_Menu";
            this.Text = "Student Menu";
            this.Load += new System.EventHandler(this.Student_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnstatus;
        private System.Windows.Forms.Button btnmainmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}