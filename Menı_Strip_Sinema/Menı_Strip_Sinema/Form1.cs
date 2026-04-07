namespace Menı_Strip_Sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;

        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;

        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Samet Kaya Tarafından Yapıldı...", "Bilgilendirme...", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cıkısToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamadan Cikis Yapilsin mi? ...", "Uyari...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Application.Exit();

        }

      

      

     
    }
}
