namespace Class_Ornek_2
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
            components = new System.ComponentModel.Container();
            btnkare = new Button();
            label1 = new Label();
            label2 = new Label();
            textkenar1 = new TextBox();
            textkenar2 = new TextBox();
            lblsonuccevre = new Label();
            btndikdortgen = new Button();
            btnsifirla = new Button();
            labelalansonuc = new Label();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnkare
            // 
            btnkare.Location = new Point(106, 144);
            btnkare.Name = "btnkare";
            btnkare.Size = new Size(162, 29);
            btnkare.TabIndex = 0;
            btnkare.Text = "Kare_Hesapla";
            btnkare.UseVisualStyleBackColor = true;
            btnkare.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 52);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 92);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // textkenar1
            // 
            textkenar1.Location = new Point(143, 49);
            textkenar1.Name = "textkenar1";
            textkenar1.Size = new Size(125, 27);
            textkenar1.TabIndex = 3;
            // 
            // textkenar2
            // 
            textkenar2.Location = new Point(143, 92);
            textkenar2.Name = "textkenar2";
            textkenar2.Size = new Size(125, 27);
            textkenar2.TabIndex = 4;
            // 
            // lblsonuccevre
            // 
            lblsonuccevre.AutoSize = true;
            lblsonuccevre.Location = new Point(323, 49);
            lblsonuccevre.Name = "lblsonuccevre";
            lblsonuccevre.Size = new Size(86, 20);
            lblsonuccevre.TabIndex = 5;
            lblsonuccevre.Text = "CevreSonuc";
            // 
            // btndikdortgen
            // 
            btndikdortgen.Location = new Point(289, 144);
            btndikdortgen.Name = "btndikdortgen";
            btndikdortgen.Size = new Size(162, 29);
            btndikdortgen.TabIndex = 6;
            btndikdortgen.Text = "Dikdörtgen_Hesapla";
            btndikdortgen.UseVisualStyleBackColor = true;
            btndikdortgen.Click += button2_Click;
            // 
            // btnsifirla
            // 
            btnsifirla.Location = new Point(183, 179);
            btnsifirla.Name = "btnsifirla";
            btnsifirla.Size = new Size(189, 42);
            btnsifirla.TabIndex = 7;
            btnsifirla.Text = "Sifirla";
            btnsifirla.UseVisualStyleBackColor = true;
            btnsifirla.Click += btnsifirla_Click;
            // 
            // labelalansonuc
            // 
            labelalansonuc.AutoSize = true;
            labelalansonuc.Location = new Point(330, 92);
            labelalansonuc.Name = "labelalansonuc";
            labelalansonuc.Size = new Size(79, 20);
            labelalansonuc.TabIndex = 8;
            labelalansonuc.Text = "AlanSonuc";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 267);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(798, 29);
            progressBar1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(256, 236);
            label3.Name = "label3";
            label3.Size = new Size(207, 28);
            label3.TabIndex = 10;
            label3.Text = "İslem Hesaplaniyor...";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(labelalansonuc);
            Controls.Add(btnsifirla);
            Controls.Add(btndikdortgen);
            Controls.Add(lblsonuccevre);
            Controls.Add(textkenar2);
            Controls.Add(textkenar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnkare);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnkare;
        private Label label1;
        private Label label2;
        private TextBox textkenar1;
        private TextBox textkenar2;
        private Label lblsonuccevre;
        private Button btndikdortgen;
        private Button btnsifirla;
        private Label labelalansonuc;
        private ProgressBar progressBar1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
