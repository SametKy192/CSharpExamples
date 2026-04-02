namespace Hastane_Projesi
{
    partial class FrmPatientLogin
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
            this.lblTcno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.linklblsignup = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(302, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Login Panel";
            // 
            // lblTcno
            // 
            this.lblTcno.AutoSize = true;
            this.lblTcno.Location = new System.Drawing.Point(299, 138);
            this.lblTcno.Name = "lblTcno";
            this.lblTcno.Size = new System.Drawing.Size(127, 28);
            this.lblTcno.TabIndex = 1;
            this.lblTcno.Text = "TC Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(437, 138);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(168, 36);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(437, 213);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(168, 36);
            this.textPassword.TabIndex = 4;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // linklblsignup
            // 
            this.linklblsignup.AutoSize = true;
            this.linklblsignup.BackColor = System.Drawing.Color.Snow;
            this.linklblsignup.Font = new System.Drawing.Font("Corbel", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklblsignup.Location = new System.Drawing.Point(937, 330);
            this.linklblsignup.Name = "linklblsignup";
            this.linklblsignup.Size = new System.Drawing.Size(124, 40);
            this.linklblsignup.TabIndex = 5;
            this.linklblsignup.TabStop = true;
            this.linklblsignup.Text = "Sign Up";
            this.linklblsignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblsignup_LinkClicked);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(437, 271);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(168, 39);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // FrmPatientLogin
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1075, 380);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.linklblsignup);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTcno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPatientLogin";
            this.Text = "Patient Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTcno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.LinkLabel linklblsignup;
        private System.Windows.Forms.Button btnlogin;
    }
}