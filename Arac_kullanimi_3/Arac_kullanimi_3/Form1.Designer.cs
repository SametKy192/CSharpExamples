namespace Arac_kullanimi_3
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
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            label3 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(183, 96);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(102, 95);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 1;
            label1.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(102, 156);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 3;
            label2.Text = "TC NO:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(183, 157);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(183, 211);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(125, 27);
            maskedTextBox3.TabIndex = 4;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(102, 211);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 5;
            label3.Text = "Tarih";
            // 
            // button1
            // 
            button1.Location = new Point(181, 251);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(509, 251);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(509, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(maskedTextBox3);
            Controls.Add(label2);
            Controls.Add(maskedTextBox2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Label label3;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
    }
}
