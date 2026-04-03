using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sql_Personel_Liste
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        void temizleme()
        {
            textİd.Text = " ";
            textAd.Text = " ";
            textSoyad.Text = " ";
            textMeslek.Text = " ";
            maskedMaas.Text = " ";
            radioButton1.Text = " ";
            radioButton2.Text = " ";
            cmbSehir.Text = " ";
            textAd.Focus();
        }


        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-P7S931M\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=False");

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet1.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open(); // acıp kapatman lazım

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel  (PerAd,PerSoyad,PerSehir,PerMaaş,PerMeslek,PerDurum)  values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", maskedMaas.Text);
            komut.Parameters.AddWithValue("@p5", textMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();// sorgu calıstırma ekle sil guncelle de kullanırız

            baglanti.Close();
            MessageBox.Show("Personel Eklendi...");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {   if(radioButton1.Checked==true)
            {
                label8.Text = "True";
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked ==true)
            {
                label8.Text = "False";
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizleme();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;


            textİd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if(label8.Text=="False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MessageBox.Show("UYARI....", "KAYIT SİLİNSİN Mİ???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            SqlCommand komutsil =new SqlCommand("Delete From Tbl_Personel Where Personelİd=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", textİd.Text);
            komutsil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi...");
            baglanti.Close();

           }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DialogResult result = MessageBox.Show("UYARI....", "KAYIT GÜNCELLENSİN ???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlCommand guncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaaş=@a4,PerDurum=@a5,PerMeslek=@a6 Where Personelİd=@a7", baglanti);
                guncelle.Parameters.AddWithValue("@a1", textAd.Text);
                guncelle.Parameters.AddWithValue("@a2", textSoyad.Text);
                guncelle.Parameters.AddWithValue("@a3", cmbSehir.Text);
                guncelle.Parameters.AddWithValue("@a4", maskedMaas.Text);
                guncelle.Parameters.AddWithValue("@a5", label8.Text);
                guncelle.Parameters.AddWithValue("@a6", textMeslek.Text);
                guncelle.Parameters.AddWithValue("@a7", textİd.Text);

                guncelle.ExecuteNonQuery();
                MessageBox.Show("Kayıt güncellendi.");
            }
            baglanti.Close();


        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr=new Frmİstatistik();
            fr.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafiikler frg = new FrmGrafiikler();
            frg.Show();
        
        
        }

        private void btnrapor_Click(object sender, EventArgs e)
        {
           
        }
    }
}
