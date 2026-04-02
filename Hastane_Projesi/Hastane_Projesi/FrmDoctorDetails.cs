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
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl=new sqlbaglanti();
        public string TC;
        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;

            //doktor name
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where  DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                lblnamesurname.Text = rdr[0] + " " + rdr[1];
            }
            bgl.baglanti().Close();

            //randevu
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuDoktor='"+lblnamesurname.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            FrmDoctorUpdateİnfo frm=new FrmDoctorUpdateİnfo();
            frm.TC=lblTC.Text;
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchcomplaint.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
