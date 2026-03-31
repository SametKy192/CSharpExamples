namespace Class_Örnek_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogr_sinif sinif = new ogr_sinif();
            sinif.ad = textad.Text;
            sinif.soyad = textsoyad.Text;
            sinif.sinif = textsinifi.Text;
            sinif.okul_no = textokulno.Text;

            string satir = "Adı: " + sinif.ad + ", Soyadı: " + sinif.soyad + ", Sınıfı: " + sinif.sinif + ", Okul No: " + sinif.okul_no;

            listBox1.Items.Add(satir);

        }
    }
}
