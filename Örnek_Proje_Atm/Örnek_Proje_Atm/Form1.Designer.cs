namespace Örnek_Proje_Atm
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
            listBox1 = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            listsonuclarigöster = new ListBox();
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            txtsoyad = new TextBox();
            txtad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textparacek = new TextBox();
            textparayatir = new TextBox();
            btnbakiye = new Button();
            btnparacek = new Button();
            btnparayatir = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(-7, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(807, 104);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(238, 21);
            label1.Name = "label1";
            label1.Size = new Size(333, 61);
            label1.TabIndex = 1;
            label1.Text = "Kaya Bankamatik";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(632, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // listsonuclarigöster
            // 
            listsonuclarigöster.FormattingEnabled = true;
            listsonuclarigöster.Location = new Point(3, 418);
            listsonuclarigöster.Name = "listsonuclarigöster";
            listsonuclarigöster.Size = new Size(797, 104);
            listsonuclarigöster.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(txtsoyad);
            groupBox1.Controls.Add(txtad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(46, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 153);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kisi Bilgileri";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(93, 118);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 6;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(93, 72);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(125, 27);
            txtsoyad.TabIndex = 4;
            // 
            // txtad
            // 
            txtad.Location = new Point(93, 32);
            txtad.Name = "txtad";
            txtad.Size = new Size(125, 27);
            txtad.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 117);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 2;
            label4.Text = "Tel.No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 75);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Soyadi:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 32);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 0;
            label2.Text = "Adi:  ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 192);
            groupBox2.Controls.Add(textparacek);
            groupBox2.Controls.Add(textparayatir);
            groupBox2.Controls.Add(btnbakiye);
            groupBox2.Controls.Add(btnparacek);
            groupBox2.Controls.Add(btnparayatir);
            groupBox2.Location = new Point(410, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 153);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yapilacak İslemler";
            // 
            // textparacek
            // 
            textparacek.Location = new Point(149, 77);
            textparacek.Name = "textparacek";
            textparacek.Size = new Size(125, 27);
            textparacek.TabIndex = 4;
            // 
            // textparayatir
            // 
            textparayatir.Location = new Point(149, 42);
            textparayatir.Name = "textparayatir";
            textparayatir.Size = new Size(125, 27);
            textparayatir.TabIndex = 3;
            // 
            // btnbakiye
            // 
            btnbakiye.Location = new Point(69, 118);
            btnbakiye.Name = "btnbakiye";
            btnbakiye.Size = new Size(151, 29);
            btnbakiye.TabIndex = 2;
            btnbakiye.Text = "Bakiye Sorgula";
            btnbakiye.UseVisualStyleBackColor = true;
            btnbakiye.Click += btnbakiye_Click;
            // 
            // btnparacek
            // 
            btnparacek.Location = new Point(40, 75);
            btnparacek.Name = "btnparacek";
            btnparacek.Size = new Size(94, 29);
            btnparacek.TabIndex = 1;
            btnparacek.Text = "Para Cek";
            btnparacek.UseVisualStyleBackColor = true;
            btnparacek.Click += btnparacek_Click;
            // 
            // btnparayatir
            // 
            btnparayatir.Location = new Point(40, 40);
            btnparayatir.Name = "btnparayatir";
            btnparayatir.Size = new Size(94, 29);
            btnparayatir.TabIndex = 0;
            btnparayatir.Text = "Para Yatir";
            btnparayatir.UseVisualStyleBackColor = true;
            btnparayatir.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Location = new Point(238, 307);
            button1.Name = "button1";
            button1.Size = new Size(309, 66);
            button1.TabIndex = 7;
            button1.Text = "Önce Kisisel Bilgileri Girmek İcin Tiklayiniz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 520);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listsonuclarigöster);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "ATM Uygulaması";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox listsonuclarigöster;
        private GroupBox groupBox1;
        private TextBox txtsoyad;
        private TextBox txtad;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button btnbakiye;
        private Button btnparacek;
        private Button btnparayatir;
        private TextBox textparacek;
        private TextBox textparayatir;
    }
}
