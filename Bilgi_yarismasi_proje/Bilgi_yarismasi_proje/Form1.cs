namespace Bilgi_yarismasi_proje
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            lblSoru.Text = soruno.ToString();
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false; // Yeniden soruya geçildiðinde resimler gizlenir
            pictureBox2.Visible = false;



            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yýlýnda Kuruldu ?";
                btnA.Text = "1924";
                btnB.Text = "1923";
                btnC.Text = "1922";
                btnD.Text = "1921";
                label4.Text = "1923";


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Fenerbahçe Kaç Yýlýnda Kuruldu ?";
                btnA.Text = "1924";
                btnB.Text = "1907";
                btnC.Text = "1905";
                btnD.Text = "1903";
                label4.Text = "1907";



            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Þuan Hangi Yýldayýz ?";
                btnA.Text = "2024";
                btnB.Text = "2023";
                btnC.Text = "2022";
                btnD.Text = "2021";
                label4.Text = "2024";



            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Ulusal Egemenlik Ve Çocuk Bayramý Hangi Aydadýr ?";
                btnA.Text = "Haziran";
                btnB.Text = "Mart";
                btnC.Text = "Mayýs";
                btnD.Text = "Nisan";
                label4.Text = "Nisan";



            }



        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }
    }
}
