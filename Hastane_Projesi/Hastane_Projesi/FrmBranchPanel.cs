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
    public partial class FrmBranchPanel : Form
    {
        public FrmBranchPanel()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl=new sqlbaglanti();
        private void FrmBranchPanel_Load(object sender, EventArgs e)
        {

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Branslar ", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textbranchname.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand branch_add = new SqlCommand("insert into Tbl_Branslar (BransAd) values(@p1)", bgl.baglanti());
            branch_add.Parameters.AddWithValue("@p1",textbranchname.Text);
            branch_add.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branch Added", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand branch_update = new SqlCommand("update Tbl_Branslar Set  BransAd=@p1 where bransid=@p2", bgl.baglanti());
            branch_update.Parameters.AddWithValue("@p1", textbranchname.Text);
            branch_update.Parameters.AddWithValue("@p2",textid.Text);
            branch_update.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branch Updated", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            SqlCommand branch_delete = new SqlCommand("Delete from Tbl_Branslar where bransid=@p1", bgl.baglanti());
        
            branch_delete.Parameters.AddWithValue("@p1", textid.Text);
            branch_delete.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branch Deleted", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
