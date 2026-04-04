namespace Sinema_büfe_proje
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
            groupBox1 = new GroupBox();
            TxtBilet = new TextBox();
            label11 = new Label();
            TxtKola = new TextBox();
            TxtCips = new TextBox();
            TxtSu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            lblKasa = new Label();
            label9 = new Label();
            button1 = new Button();
            lblToplam = new Label();
            label4 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(TxtBilet);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(TxtKola);
            groupBox1.Controls.Add(TxtCips);
            groupBox1.Controls.Add(TxtSu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(81, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 277);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktari";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // TxtBilet
            // 
            TxtBilet.Location = new Point(98, 217);
            TxtBilet.Name = "TxtBilet";
            TxtBilet.Size = new Size(125, 31);
            TxtBilet.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 217);
            label11.Name = "label11";
            label11.Size = new Size(57, 25);
            label11.TabIndex = 8;
            label11.Text = "Bilet:";
            // 
            // TxtKola
            // 
            TxtKola.Location = new Point(98, 111);
            TxtKola.Name = "TxtKola";
            TxtKola.Size = new Size(125, 31);
            TxtKola.TabIndex = 7;
            // 
            // TxtCips
            // 
            TxtCips.Location = new Point(98, 164);
            TxtCips.Name = "TxtCips";
            TxtCips.Size = new Size(125, 31);
            TxtCips.TabIndex = 5;
            // 
            // TxtSu
            // 
            TxtSu.Location = new Point(98, 59);
            TxtSu.Name = "TxtSu";
            TxtSu.Size = new Size(125, 31);
            TxtSu.TabIndex = 3;
            TxtSu.TextChanged += TxtSu_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 164);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "Cips:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 111);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "Kola:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 59);
            label1.Name = "label1";
            label1.Size = new Size(38, 25);
            label1.TabIndex = 0;
            label1.Text = "Su:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 192);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(448, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 277);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fiyat Tablosu";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 220);
            label8.Name = "label8";
            label8.Size = new Size(107, 25);
            label8.TabIndex = 4;
            label8.Text = "Bilet: 15 TL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 170);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 3;
            label7.Text = "Cips: 8 TL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 117);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 2;
            label6.Text = "Kola: 10 TL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 65);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 1;
            label5.Text = "Su: 4 TL";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 255, 192);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(lblKasa);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(lblToplam);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(798, 121);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 277);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // button2
            // 
            button2.Location = new Point(96, 181);
            button2.Name = "button2";
            button2.Size = new Size(93, 38);
            button2.TabIndex = 7;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblKasa
            // 
            lblKasa.AutoSize = true;
            lblKasa.Location = new Point(132, 234);
            lblKasa.Name = "lblKasa";
            lblKasa.Size = new Size(57, 25);
            lblKasa.TabIndex = 6;
            lblKasa.Text = "00 TL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 234);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 5;
            label9.Text = "Kasa: ";
            // 
            // button1
            // 
            button1.Location = new Point(90, 129);
            button1.Name = "button1";
            button1.Size = new Size(104, 46);
            button1.TabIndex = 4;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(137, 78);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(57, 25);
            lblToplam.TabIndex = 3;
            lblToplam.Text = "00 TL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 78);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 2;
            label4.Text = "Toplam: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label10.Location = new Point(62, 37);
            label10.Name = "label10";
            label10.Size = new Size(597, 46);
            label10.TabIndex = 3;
            label10.Text = "Kaya Sinema_Büfe Satis Platformu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(827, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 562);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Sinema_Büfe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtSu;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox TxtKola;
        private TextBox TxtCips;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblKasa;
        private Label label9;
        private Button button1;
        private Label lblToplam;
        private Label label4;
        private Label label11;
        private TextBox TxtBilet;
        private Label label8;
        private Button button2;
        private Label label10;
        private PictureBox pictureBox1;
    }
}
