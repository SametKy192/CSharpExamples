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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P7S931M\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=False");
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Personel",baglanti);
            SqlDataReader dr1=komut1.ExecuteReader();
            while(dr1.Read())
            {
                lbltoplampersonel.Text = dr1[0].ToString(); 
            }

            dr1.Close();

            SqlCommand komut2 = new SqlCommand("select sum(PerMaaş) from Tbl_Personel",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbltoplammaas.Text = dr2[0].ToString();
            }
            dr2.Close();

            SqlCommand komut3 = new SqlCommand("select avg(PerMaaş) from Tbl_Personel", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader(); 
            while (dr3.Read()) 
            {
                  lblortalamamaas.Text = dr3[0].ToString();
            }
            dr3.Close();

            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblsehirsayisi.Text = dr4[0].ToString();
            }
            dr4.Close();


            SqlCommand komut5 = new SqlCommand("select count(*) From Tbl_Personel where Perdurum=0", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblevlipersonel.Text = dr5[0].ToString();
            }
            dr5.Close();

            SqlCommand komut6 = new SqlCommand("select count(*) From Tbl_Personel where Perdurum=1", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblbekarpersonel.Text = dr6[0].ToString();
            }
            dr6.Close();


            baglanti.Close();   
        }
    }
}
