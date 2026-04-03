namespace veri_tipleri_örnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int not1, not2, proje;
            double ortalama;
            ad = textBox4.Text;
            soyad=textBox5.Text;
            not1=Convert.ToInt32(textBox1.Text);
            not2=Convert.ToInt32(textBox2.Text);
            proje = Convert.ToInt32(textBox3.Text);
            ortalama = (not1 + not2 + proje) / 3;
            listBox1.Items.Add( ad +" "+soyad + " " + " Ortalama: " + ortalama);
            

                
                }
    }
}
