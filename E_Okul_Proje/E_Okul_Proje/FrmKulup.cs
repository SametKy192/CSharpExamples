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

namespace E_Okul_Proje
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }
        Sql_bgl bgl=new Sql_bgl();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut_add=new SqlCommand("insert into TBLKLUPLER (KLUPAD) values(@p1) ",bgl.baglanti());
            komut_add.Parameters.AddWithValue("@p1", textclubname.Text);
            komut_add.ExecuteNonQuery();
            MessageBox.Show("Club Added", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut_delete = new SqlCommand("Delete From TBLKLUPLER where KLUPID=@p1", bgl.baglanti());
            komut_delete.Parameters.AddWithValue("@p1",textclubid.Text);
            komut_delete.ExecuteNonQuery();
            MessageBox.Show("Club Deleted", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut_update = new SqlCommand("Update  TBLKLUPLER set KLUPAD=@p1 where KLUPID=@p2", bgl.baglanti());
            komut_update.Parameters.AddWithValue("@p1",textclubname.Text);
            komut_update.Parameters.AddWithValue("@p2", textclubid.Text);
            komut_update.ExecuteNonQuery();
            MessageBox.Show("Club Updated", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLKLUPLER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textclubid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textclubname.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
