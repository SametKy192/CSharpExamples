




namespace Arac_kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Samet";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Samet";
            label6.Text = "Kaya";
            label8.Text = "Yazýlýmcý";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazýlým mühendisliði";
            label9.Text = textBox1.Text;
            Text = "YAZILIM";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
