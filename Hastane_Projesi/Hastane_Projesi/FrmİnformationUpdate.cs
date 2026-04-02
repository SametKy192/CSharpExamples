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

namespace Hastane_Projesi
{
    public partial class FrmİnformationUpdate : Form
    {
        public FrmİnformationUpdate()
        {
            InitializeComponent();
        }
        public string TCno;

        sqlbaglanti bgl=new sqlbaglanti();
        private void FrmİnformationUpdate_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                textName.Text = dr[1].ToString();
                textSurname.Text = dr[2].ToString();
                mskTelephone.Text = dr[4].ToString();
                textPassword.Text = dr[5].ToString();
                cmbGender.Text = dr[6].ToString();
            }
            dr.Close();
            bgl.baglanti().Close();
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand güncelle = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            güncelle.Parameters.AddWithValue("@p1",textName.Text);
            güncelle.Parameters.AddWithValue("@p2",textSurname.Text);
            güncelle.Parameters.AddWithValue("@p3",mskTelephone.Text);
            güncelle.Parameters.AddWithValue("@p4",textPassword.Text);
            güncelle.Parameters.AddWithValue("@p5",cmbGender.Text);
            güncelle.Parameters.AddWithValue("@p6", mskTC.Text);
            güncelle.ExecuteNonQuery();
            bgl.baglanti().Close() ;


            SqlDataReader dr2= güncelle.ExecuteReader();

             MessageBox.Show("Your Information Has Been Updated","İnformation",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
