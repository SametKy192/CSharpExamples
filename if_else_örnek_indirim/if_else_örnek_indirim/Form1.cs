namespace if_else_örnek_indirim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            int fiyat = 8;
            double tutar;
            adet = Convert.ToInt32(textkitapsayisi.Text);

            if (adet >= 0 && adet <= 20) 
            {
               tutar=(adet*fiyat) -(adet*fiyat*0.20);
                lbltutar.Text = tutar + "TL";
            }
           if(adet>=21 && adet<=40)
            {
                tutar = (adet * fiyat) - (adet * fiyat * 0.40);
                lbltutar.Text = tutar + "TL";
            }
            if (adet >= 41)
            {
                tutar = (adet * fiyat) - (adet * fiyat * 0.50);
                lbltutar.Text = tutar + "TL";
            }


        }
    }
}
