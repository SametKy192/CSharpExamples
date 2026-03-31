namespace Arac_kullanimi_2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa", "Ankara", "Balıkesir", "Gaziantep", "İstanbul", "Malatya" });
            comboBox1.Location = new Point(214, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(221, 150);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 1;
            button1.Text = "Sehir Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(612, 130);
            button2.Name = "button2";
            button2.Size = new Size(151, 36);
            button2.TabIndex = 2;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 45);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 3;
            label1.Text = "Sehir";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(638, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 32);
            textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Yazılım", "Bilgisayar", "Polis", "Asker", "Öğretmen", "Manav", "Bakkal", "Market", "Hastane" });
            listBox1.Location = new Point(22, 45);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 129);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(71, 218);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 351);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
    }
}
