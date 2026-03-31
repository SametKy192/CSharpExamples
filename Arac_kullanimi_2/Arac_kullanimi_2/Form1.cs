namespace Arac_kullanimi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Hatay");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            MessageBox.Show("Sehir Eklendi");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Eczane");
        }
    }
}
