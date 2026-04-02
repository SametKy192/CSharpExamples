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
using System.Net.Http.Headers;

namespace E_Okul_Proje
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        Sql_bgl bgl = new Sql_bgl();
        public string numara;
        public string ad;

        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM From TBLNOTLAR INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID=TBLDERSLER.DERSID Where OGRENCIID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
           // this.Text=numara.ToString();
           SqlDataAdapter da= new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("Select OGRAD,OGRSOYAD From TBLOGRENCILER where OGRID=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", numara);
            SqlDataReader rdr = komut2.ExecuteReader();
            while (rdr.Read())
            {
                this.Text = rdr[0] + " " + rdr[1];
            }
            bgl.baglanti().Close();


        }
    }
}
