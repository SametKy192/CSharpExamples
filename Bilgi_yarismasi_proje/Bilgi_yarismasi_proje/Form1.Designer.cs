namespace Bilgi_yarismasi_proje
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
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSoru = new Label();
            lblDogru = new Label();
            lblYanlis = new Label();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(-1, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(658, 217);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(-1, 224);
            btnA.Name = "btnA";
            btnA.Size = new Size(219, 48);
            btnA.TabIndex = 2;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(-1, 278);
            btnB.Name = "btnB";
            btnB.Size = new Size(219, 48);
            btnB.TabIndex = 3;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(298, 224);
            btnC.Name = "btnC";
            btnC.Size = new Size(215, 48);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += button3_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(298, 278);
            btnD.Name = "btnD";
            btnD.Size = new Size(215, 48);
            btnD.TabIndex = 5;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // button5
            // 
            button5.Location = new Point(169, 315);
            button5.Name = "button5";
            button5.Size = new Size(8, 8);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(736, 13);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 7;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(754, 70);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 8;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(754, 124);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 9;
            label3.Text = "Yanlış:";
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(835, 13);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(26, 30);
            lblSoru.TabIndex = 10;
            lblSoru.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(835, 70);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(26, 30);
            lblDogru.TabIndex = 11;
            lblDogru.Text = "0";
            lblDogru.Click += label5_Click;
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(835, 124);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(26, 30);
            lblYanlis.TabIndex = 12;
            lblYanlis.Text = "0";
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(754, 180);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(113, 38);
            btnSonraki.TabIndex = 14;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(754, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(904, 245);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 342);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 17;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(691, 371);
            label5.Name = "label5";
            label5.Size = new Size(72, 30);
            label5.TabIndex = 18;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 353);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSonraki);
            Controls.Add(lblYanlis);
            Controls.Add(lblDogru);
            Controls.Add(lblSoru);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Font = new Font("Segoe Script", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Bilgi Yarismasi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSoru;
        private Label lblDogru;
        private Label lblYanlis;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
