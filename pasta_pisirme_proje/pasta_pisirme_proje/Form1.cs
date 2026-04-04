namespace pasta_pisirme_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.Blue;
            }

            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Purple;
            }



            if (progressBar1.Value == 100)
            {
                label1.BackColor = Color.Red;
                timer1.Stop();


                label1.Text = "Karistirma Ýslemi Bitti";
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;

            if (progressBar2.Value % 10 == 5)
            {
                label2.BackColor = Color.Blue;
            }

            if (progressBar2.Value % 10 == 0)
            {
                label2.BackColor = Color.Purple;
            }



            if (progressBar2.Value == 100)
            {

                timer2.Stop();
                label2.BackColor = Color.Red;
                label2.Text = "Cirpma Ýslemi Bitti";
                timer3.Start();
            }




        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;

            if (progressBar3.Value % 20 == 10)
            {
                label1.BackColor = Color.Blue;
            }

            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.Purple;
            }



            if (progressBar3.Value == 100)
            {
                label3.BackColor = Color.Red;
                timer3.Stop();


                label3.Text = "Malzemeler Eklendi";
                timer4.Start();
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10;

            if (progressBar4.Value % 20 == 10)
            {
                label4.BackColor = Color.Blue;
            }

            if (progressBar4.Value % 20 == 0)
            {
                label4.BackColor = Color.Purple;
            }



            if (progressBar4.Value == 100)
            {
                label4.BackColor = Color.Red;
                timer4.Stop();


                label4.Text = "Pasta Pismesi Bitti";
                MessageBox.Show("Pastaniz Hazir Oldu...");
               
            }
        }
    }
}
