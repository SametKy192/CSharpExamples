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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P7S931M\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=False");
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand giris = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAd=@p1 and Sifre=@p2",baglanti);
            giris.Parameters.AddWithValue("@p1", textKullaniciadi.Text);
            giris.Parameters.AddWithValue("@p2", textSifre.Text);

            SqlDataReader dr=giris.ExecuteReader();
            if (dr.Read()) 
            {
               FrmAnaForm frmana=new FrmAnaForm();
                frmana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı  veya Şifre Girdiniz...");
            }


            baglanti.Close();
        }
    }
}
