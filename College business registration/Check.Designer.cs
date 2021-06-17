namespace College_business_registration
{
    partial class Check
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
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnreceipt = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnlicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(415, 398);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(64, 37);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLEASE ENTER STUDENT ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 63);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 27);
            this.txtID.TabIndex = 3;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 20;
            this.lstDisplay.Location = new System.Drawing.Point(74, 122);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(323, 164);
            this.lstDisplay.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(314, 58);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(83, 37);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.Location = new System.Drawing.Point(337, 398);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(70, 37);
            this.btnmenu.TabIndex = 17;
            this.btnmenu.Text = "MENU";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btnreceipt
            // 
            this.btnreceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnreceipt.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreceipt.Location = new System.Drawing.Point(84, 310);
            this.btnreceipt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnreceipt.Name = "btnreceipt";
            this.btnreceipt.Size = new System.Drawing.Size(144, 41);
            this.btnreceipt.TabIndex = 18;
            this.btnreceipt.Text = "PRINT RECEIPT";
            this.btnreceipt.UseVisualStyleBackColor = false;
            this.btnreceipt.Click += new System.EventHandler(this.btnreceipt_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // btnlicense
            // 
            this.btnlicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnlicense.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlicense.Location = new System.Drawing.Point(254, 310);
            this.btnlicense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlicense.Name = "btnlicense";
            this.btnlicense.Size = new System.Drawing.Size(131, 41);
            this.btnlicense.TabIndex = 19;
            this.btnlicense.Text = "ISSUE LICENSE";
            this.btnlicense.UseVisualStyleBackColor = false;
            this.btnlicense.Click += new System.EventHandler(this.btnlicense_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(483, 447);
            this.Controls.Add(this.btnlicense);
            this.Controls.Add(this.btnreceipt);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Check";
            this.Text = "CHECK STATUS ";
            this.Load += new System.EventHandler(this.Check_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnreceipt;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnlicense;
    }
}