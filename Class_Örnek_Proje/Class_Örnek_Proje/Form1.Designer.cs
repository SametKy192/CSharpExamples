namespace Class_Örnek_Proje
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            textad = new TextBox();
            textsoyad = new TextBox();
            textsinifi = new TextBox();
            textokulno = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 29);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 67);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 107);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Sınıfı:";
            // 
            // button1
            // 
            button1.Location = new Point(305, 199);
            button1.Name = "button1";
            button1.Size = new Size(114, 45);
            button1.TabIndex = 3;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(140, 314);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(480, 104);
            listBox1.TabIndex = 4;
            // 
            // textad
            // 
            textad.Location = new Point(188, 26);
            textad.Name = "textad";
            textad.Size = new Size(125, 27);
            textad.TabIndex = 5;
            // 
            // textsoyad
            // 
            textsoyad.Location = new Point(188, 67);
            textsoyad.Name = "textsoyad";
            textsoyad.Size = new Size(125, 27);
            textsoyad.TabIndex = 6;
            // 
            // textsinifi
            // 
            textsinifi.Location = new Point(188, 107);
            textsinifi.Name = "textsinifi";
            textsinifi.Size = new Size(125, 27);
            textsinifi.TabIndex = 7;
            // 
            // textokulno
            // 
            textokulno.Location = new Point(188, 151);
            textokulno.Name = "textokulno";
            textokulno.Size = new Size(125, 27);
            textokulno.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 154);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Okul_no:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textokulno);
            Controls.Add(textsinifi);
            Controls.Add(textsoyad);
            Controls.Add(textad);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ListBox listBox1;
        private TextBox textad;
        private TextBox textsoyad;
        private TextBox textsinifi;
        private TextBox textokulno;
        private Label label4;
    }
}
