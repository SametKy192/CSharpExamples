namespace Sinema_büfe_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int su, kola, cips, bilet, toplam;
            su = Convert.ToInt32(TxtSu.Text);
            kola = Convert.ToInt32(TxtKola.Text);
            cips = Convert.ToInt32(TxtCips.Text);
            bilet = Convert.ToInt32(TxtBilet.Text);
            toplam = su * 4 + kola * 10 + cips * 8 + bilet * 15;

            lblToplam.Text = toplam.ToString() + "TL";
            kasatutar += toplam;
            lblKasa.Text = kasatutar.ToString() + "TL";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCips.Text = "";
            TxtKola.Text = "";
            TxtSu.Text = "";
            TxtSu.Focus();
        }

        private void TxtSu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
