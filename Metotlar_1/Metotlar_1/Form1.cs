namespace Metotlar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox1.Focus();
        }
        void renklendir()
        {
            textBox1.BackColor = Color.Red;
            textBox2.BackColor = Color.Green;
            textBox3.BackColor = Color.Blue;
            textBox4.BackColor = Color.Tan;
        }
        void renk_temizle()
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
        }
        void bilgi()
        {
            textBox1.Text = "Samet";
            textBox2.Text = "Kaya";
            textBox3.Text = "Yazýlým";
            textBox4.Text = "1923";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bilgi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            renk_temizle();
        }
    }
}
