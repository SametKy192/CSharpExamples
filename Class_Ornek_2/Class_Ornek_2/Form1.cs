namespace Class_Ornek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double HesaplaCevre(double kenar1, double kenar2)
        {
            return (kenar1 + kenar2) * 2;
        }

        private double HesaplaAlan(double kenar1, double kenar2)
        {
            return (kenar1 * kenar2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            btndikdortgen.Enabled = false;
            Hesaplama hsp = new Hesaplama();
            hsp.knr_1 = Convert.ToDouble(textkenar1.Text);
            hsp.knr_2 = Convert.ToDouble(textkenar2.Text);

            double cevre = HesaplaCevre(hsp.knr_1, hsp.knr_2);
            double alan = HesaplaAlan(hsp.knr_1, hsp.knr_2);
            lblsonuccevre.Text = "Çevre: " + cevre.ToString();
            labelalansonuc.Text = "Alan: " + alan.ToString();
            btnkare.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
       

            btnkare.Enabled = false;
            Hesaplama hsp = new Hesaplama();
            hsp.knr_1 = Convert.ToDouble(textkenar1.Text);
            hsp.knr_2 = Convert.ToDouble(textkenar2.Text);

            double cevre = HesaplaCevre(hsp.knr_1, hsp.knr_2);
            double alan = HesaplaAlan(hsp.knr_1, hsp.knr_2);

            lblsonuccevre.Text = "Çevre: " + cevre.ToString();
            labelalansonuc.Text = "Alan: " + alan.ToString();

            btndikdortgen.Enabled = false;
        }

        private void btnsifirla_Click(object sender, EventArgs e)
        {
            textkenar1.Text = " ";
            textkenar2.Text = " ";
            lblsonuccevre.Text = " ";
            label3.BackColor = Color.White;
            progressBar1.Value =0 ;             
            btndikdortgen.Enabled = true;
            btnkare.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.Blue;
                label2.BackColor = Color.Purple;
            }

            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Purple;

                label2.BackColor = Color.Blue;
            }



            if (progressBar1.Value == 100)
            {
                label3.BackColor = Color.Red;
                timer1.Stop();

                label3.Text = "Hesaplama Ýslemi Bitti";
               
            }





        }
    }
}
