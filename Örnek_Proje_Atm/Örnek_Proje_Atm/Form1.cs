namespace Örnek_Proje_Atm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, telefon;
            ad = txtad.Text;
            soyad = txtsoyad.Text;
            telefon = maskedTextBox1.Text;
            listsonuclarigöster.Items.Add(" Kisisel Bilgiler :" + ad + " " + soyad + " " + telefon);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //pARA yatir
        double bakiye = 5000;
        private void button3_Click(object sender, EventArgs e)
        {
            double para_yatir;
            para_yatir = Convert.ToDouble(textparayatir.Text);
            bakiye += para_yatir;
            listsonuclarigöster.Items.Add("Toplam Bakiye: " + bakiye);
        }

        private void btnparacek_Click(object sender, EventArgs e)
        {
            double para_cek;
            para_cek = Convert.ToDouble(textparacek.Text);
            bakiye -= para_cek;
            listsonuclarigöster.Items.Add("Kalan Bakiye : " + bakiye);

        }

        private void btnbakiye_Click(object sender, EventArgs e)
        {
            listsonuclarigöster.Items.Add("Bakiyeniz : " + bakiye);

        }
    }
}
