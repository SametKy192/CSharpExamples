namespace math_fonksiyonlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi=Convert.ToDouble(textBox1.Text);
            label1.Text = Math.Abs(sayi).ToString();
        }
    }
}
/*
 abs=mutlak
ceil:üste yuvarlamak
Floor:alta yuvarlamak
pow:üs
sqrt:karesini alýr
 
 
 
 */