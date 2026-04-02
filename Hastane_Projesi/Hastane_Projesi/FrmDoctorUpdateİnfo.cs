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
    public partial class FrmDoctorUpdateİnfo : Form
    {
        public FrmDoctorUpdateİnfo()
        {
            InitializeComponent();
        }
        public string TC;
        sqlbaglanti bgl=new sqlbaglanti();

        private void FrmDoctorUpdateİnfo_Load(object sender, EventArgs e)
        {
            mskTC.Text = TC;

            SqlCommand komut = new SqlCommand("Select *From Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while(dr.Read())
            {
                textName.Text = dr[1].ToString();
                textSurname.Text = dr[2].ToString();
                cmbBranch.Text = dr[3].ToString();
                textPassword.Text = dr[5].ToString();

            }

            bgl.baglanti().Close();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            SqlCommand komut1 = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",textName.Text);
            komut1.Parameters.AddWithValue("@p2", textSurname.Text);
            komut1.Parameters.AddWithValue("@p3", cmbBranch.Text);
            komut1.Parameters.AddWithValue("@p4", textPassword.Text);
            komut1.Parameters.AddWithValue("@p5", mskTC.Text);

            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Updated");


        }
    }
}
