namespace Enum_Yapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Sehirler { Adana, Adýyaman, Afyon, Aðrý, Amasya, Ankara, Antalya, Artvin, Aydin }
        // enumda buyuk harf lazým
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka=Convert.ToInt32(textBox1.Text);
            Sehirler s;
            s=(Sehirler)plaka;
            label1.Text=s.ToString();
        }
    }
}
