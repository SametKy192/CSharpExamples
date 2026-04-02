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
    public partial class Frmpatientdetails : Form
    {
        public Frmpatientdetails()
        {
            InitializeComponent();
        }

         sqlbaglanti bgl=new sqlbaglanti();
        public string tc;

        private void Frmpatientdetails_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;



            // adsoyad cekme
            SqlCommand komut=new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTC.Text);    
            SqlDataReader dr=komut.ExecuteReader(); 
            while(dr.Read())
            {
                lblnamesurname.Text = dr[0] + " " + dr[1];
            }
            dr.Close();
            bgl.baglanti().Close();


            // randevu gecmısı

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları cekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from tbl_Branslar", bgl.baglanti());
            SqlDataReader  dr2=komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbbranch.Items.Add(dr2[0]);
            }
            dr2.Close();
            bgl.baglanti().Close();


        }

        private void cmbbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctors.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbbranch.Text);
            SqlDataReader dr3=komut3.ExecuteReader();
            while(dr3.Read())
            {
                cmbDoctors.Items.Add(dr3[0] + " " + dr3[1]);
            }
            dr3.Close();
            bgl.baglanti().Close();
        
        }

        private void cmbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuBrans='" + cmbbranch.Text + "' AND RandevuDoktor='" + cmbDoctors.Text + "'and RandevuDurum=0", bgl.baglanti());


            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkupdateinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmİnformationUpdate frm =new FrmİnformationUpdate();
            frm.TCno = lblTC.Text;
            frm.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnappointment_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_take = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTC=@p1,RandevuSikayet=@p2 where Randevuid=@p3",bgl.baglanti());
            cmd_take.Parameters.AddWithValue("@p1",lblTC.Text);
            cmd_take.Parameters.AddWithValue("@p2",rchcomplaint.Text);
            cmd_take.Parameters.AddWithValue("@p3",textid.Text);
            cmd_take.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Process Is Succesful","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
