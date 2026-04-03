namespace Ucus_rezervasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota : " + comboBox1.Text + " - " + comboBox2.Text +
             " Tarih : " + dateTimePicker1.Text +
             " Saat : " + maskedTextBox1.Text +
             " Yolcu Bilgileri --> Ad: " + textBox1.Text + " TC : " + maskedTextBox2.Text +
             " Telefon No: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tempText = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = tempText;
        }
    }
}
