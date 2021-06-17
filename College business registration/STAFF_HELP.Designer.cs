namespace College_business_registration
{
    partial class STAFF_HELP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STAFF_HELP));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstGuide = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.Color.LightCoral;
            this.btndisplay.Font = new System.Drawing.Font("Maiandra GD", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.ForeColor = System.Drawing.Color.White;
            this.btndisplay.Location = new System.Drawing.Point(175, 87);
            this.btndisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(149, 41);
            this.btndisplay.TabIndex = 6;
            this.btndisplay.Text = "ASK FOR HELP";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Guideline for status approval update";
            // 
            // lstGuide
            // 
            this.lstGuide.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuide.FormattingEnabled = true;
            this.lstGuide.ItemHeight = 27;
            this.lstGuide.Location = new System.Drawing.Point(41, 183);
            this.lstGuide.Margin = new System.Windows.Forms.Padding(4);
            this.lstGuide.Name = "lstGuide";
            this.lstGuide.Size = new System.Drawing.Size(404, 193);
            this.lstGuide.TabIndex = 4;
            // 
            // STAFF_HELP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(488, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGuide);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "STAFF_HELP";
            this.Text = "STAFF GUIDE ";
            this.Load += new System.EventHandler(this.STAFF_HELP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstGuide;
    }
}