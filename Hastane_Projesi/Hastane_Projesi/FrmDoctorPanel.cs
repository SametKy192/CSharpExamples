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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl=new sqlbaglanti();
        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar ", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            //branşları comboboxa cekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            dr2.Close();
            bgl.baglanti().Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            SqlCommand adddoctor=new SqlCommand(" insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values(@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            adddoctor.Parameters.AddWithValue("@p1",textname.Text);
            adddoctor.Parameters.AddWithValue("@p2", textSurname.Text);
            adddoctor.Parameters.AddWithValue("@p3", cmbBranch.Text);
            adddoctor.Parameters.AddWithValue("@p4", mskTC.Text);
            adddoctor.Parameters.AddWithValue("@p5", textPassword.Text);
            adddoctor.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor Added","İnformation",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textname.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBranch.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textPassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SqlCommand remove_doktor=new SqlCommand("delete from Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            remove_doktor.Parameters.AddWithValue("@p1",mskTC.Text);
            remove_doktor.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor Removed", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand update_doktor = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4",bgl.baglanti());
            update_doktor.Parameters.AddWithValue("@p1",textname.Text);
            update_doktor.Parameters.AddWithValue("@p2", textSurname.Text);
            update_doktor.Parameters.AddWithValue("@p3", cmbBranch.Text);
            update_doktor.Parameters.AddWithValue("@p4", mskTC.Text);
            update_doktor.Parameters.AddWithValue("@p5", textPassword.Text);

            update_doktor.ExecuteNonQuery(); 
            bgl.baglanti().Close();
            MessageBox.Show("Doctor Updated", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
