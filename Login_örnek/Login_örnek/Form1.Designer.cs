namespace Login_örnek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 249);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik Numara";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(334, 249);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(182, 34);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(334, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 34);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 303);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 192, 192);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1101, 148);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Location = new Point(0, 439);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 63);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(392, 343);
            button1.Name = "button1";
            button1.Size = new Size(124, 44);
            button1.TabIndex = 6;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(549, 305);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(186, 32);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Şifremi Unuttum";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(58, 39);
            label3.Name = "label3";
            label3.Size = new Size(390, 46);
            label3.TabIndex = 8;
            label3.Text = "Online Ders Giriş Paneli";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(671, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Kullanıcı Giriş Paneli";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button button1;
        private CheckBox checkBox1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
