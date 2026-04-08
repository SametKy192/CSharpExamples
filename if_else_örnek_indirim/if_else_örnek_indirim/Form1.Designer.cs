namespace if_else_örnek_indirim
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
            label1 = new Label();
            textkitapsayisi = new TextBox();
            label2 = new Label();
            lbltutar = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 45);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adet Sayısı:";
            // 
            // textkitapsayisi
            // 
            textkitapsayisi.Location = new Point(286, 45);
            textkitapsayisi.Name = "textkitapsayisi";
            textkitapsayisi.Size = new Size(125, 27);
            textkitapsayisi.TabIndex = 1;
            textkitapsayisi.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 108);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Tutar: ";
            // 
            // lbltutar
            // 
            lbltutar.AutoSize = true;
            lbltutar.Location = new Point(286, 108);
            lbltutar.Name = "lbltutar";
            lbltutar.Size = new Size(44, 20);
            lbltutar.TabIndex = 3;
            lbltutar.Text = "00 TL";
            // 
            // button1
            // 
            button1.Location = new Point(330, 201);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lbltutar);
            Controls.Add(label2);
            Controls.Add(textkitapsayisi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textkitapsayisi;
        private Label label2;
        private Label lbltutar;
        private Button button1;
    }
}
