namespace Hastane_Projesi
{
    partial class FrmLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogins));
            this.btnpatientlogin = new System.Windows.Forms.Button();
            this.btndoctorlogin = new System.Windows.Forms.Button();
            this.btnsecretarylogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpatientlogin
            // 
            this.btnpatientlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpatientlogin.BackgroundImage")));
            this.btnpatientlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpatientlogin.Location = new System.Drawing.Point(40, 246);
            this.btnpatientlogin.Name = "btnpatientlogin";
            this.btnpatientlogin.Size = new System.Drawing.Size(274, 187);
            this.btnpatientlogin.TabIndex = 0;
            this.btnpatientlogin.UseVisualStyleBackColor = true;
            this.btnpatientlogin.Click += new System.EventHandler(this.btnpatient_Click);
            // 
            // btndoctorlogin
            // 
            this.btndoctorlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoctorlogin.BackgroundImage")));
            this.btndoctorlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoctorlogin.Location = new System.Drawing.Point(423, 246);
            this.btndoctorlogin.Name = "btndoctorlogin";
            this.btndoctorlogin.Size = new System.Drawing.Size(274, 187);
            this.btndoctorlogin.TabIndex = 1;
            this.btndoctorlogin.UseVisualStyleBackColor = true;
            this.btndoctorlogin.Click += new System.EventHandler(this.btndoctorlogin_Click);
            // 
            // btnsecretarylogin
            // 
            this.btnsecretarylogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsecretarylogin.BackgroundImage")));
            this.btnsecretarylogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsecretarylogin.Location = new System.Drawing.Point(783, 246);
            this.btnsecretarylogin.Name = "btnsecretarylogin";
            this.btnsecretarylogin.Size = new System.Drawing.Size(274, 187);
            this.btnsecretarylogin.TabIndex = 2;
            this.btnsecretarylogin.UseVisualStyleBackColor = true;
            this.btnsecretarylogin.Click += new System.EventHandler(this.btnsecretarylogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(461, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(806, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secretary Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(736, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(146, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 76);
            this.label4.TabIndex = 7;
            this.label4.Text = "...Kaya Hospital...";
            // 
            // FrmLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1147, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsecretarylogin);
            this.Controls.Add(this.btndoctorlogin);
            this.Controls.Add(this.btnpatientlogin);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmLogins";
            this.Text = "Kaya Hospital Login";
            this.Load += new System.EventHandler(this.FrmLogins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpatientlogin;
        private System.Windows.Forms.Button btndoctorlogin;
        private System.Windows.Forms.Button btnsecretarylogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

