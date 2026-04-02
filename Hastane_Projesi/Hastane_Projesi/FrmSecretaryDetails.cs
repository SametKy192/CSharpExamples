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
    public partial class FrmSecretaryDetails : Form
    {
        public FrmSecretaryDetails()
        {
            InitializeComponent();
        }
        public string TcNumber;
        sqlbaglanti bgl=new sqlbaglanti();
        private void FrmSecretaryDetails_Load(object sender, EventArgs e)
        {
            LblTc.Text= TcNumber;
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreterler where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",LblTc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblNameSurname.Text = dr1[0].ToString();
            }
            dr1.Close();
            bgl.baglanti().Close();


            //Bransları cektık grıedvıew oldugu zaman table olustururuz
            DataTable dt1=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Bransid,BransAd As Branches from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //doktor listeye cagırma
            DataTable dt2=new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) As Doctors ,DoktorBrans From Tbl_Doktorlar ", bgl.baglanti());
            da2.Fill(dt2);  
            dataGridView2.DataSource = dt2;

            // brans getir
            SqlCommand bransgetir = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = bransgetir.ExecuteReader();
            while(dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();



        }

      
        private void btnSave_Click(object sender, EventArgs e)
        {
            //
            SqlCommand komutsave = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutsave.Parameters.AddWithValue("@r1",mskDate.Text);
            komutsave.Parameters.AddWithValue("@r2",mskTime.Text);
            komutsave.Parameters.AddWithValue("@r3", cmbBranch.Text);
            komutsave.Parameters.AddWithValue("@r4",cmbDoctor.Text);
            komutsave.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Appointment created");

        

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            dr3.Close();
            bgl.baglanti().Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("insert into Tbl_Duyurular(Duyuru) values(@d1)", bgl.baglanti());
            komut4.Parameters.AddWithValue("@d1",rchannounce.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("announcement created...");
        }

        private void btnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel drp=new FrmDoctorPanel();
            drp.Show();
        }

        private void btnBranchPanel_Click(object sender, EventArgs e)
        {
            FrmBranchPanel drp=new FrmBranchPanel();
            drp.Show();
            this.Hide();
        }

        private void btnappointmentList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList drp=new FrmAppointmentList();
            drp.Show();
            this.Hide();
        }

        private void btnoldannounce_Click(object sender, EventArgs e)
        {
            Frmannounces frmannounces = new Frmannounces();
            frmannounces.Show();
            this.Hide();    
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
