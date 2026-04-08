namespace Kapsülleme_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kapsülleme kps =new kapsülleme();
            kps.renk = "Mavi";
            kps.hiz = 200;
            kps.motor = 20023;
            kps.durum = 'S';
            kps.YIL = -2016;
            kps.Markasi = "bmw";
            kps.kisi_adi="Samet Kaya"

            label1.Text= kps.renk;
            label2.Text=kps.hiz.ToString();
            label3.Text= kps.motor.ToString();
            label4.Text= kps.durum.ToString();
            label5.Text=kps.YIL.ToString();
            label6.Text=kps.Markasi;
            label7.Text = kps.kisi_adi;


        }
    }
}
