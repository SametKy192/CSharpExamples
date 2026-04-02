using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Okul_Proje
{
    public partial class FrmLessonOGRT : Form
    {
        public FrmLessonOGRT()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();

        private void FrmLessonOGRT_Load(object sender, EventArgs e)
        {
           
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ds.DersEkle(textlessonname.Text);
            MessageBox.Show("Lesson Added");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(textlessonid.Text));
            MessageBox.Show("Lesson Deleted");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(textlessonname.Text, byte.Parse(textlessonid.Text));
            MessageBox.Show("Lesson Updated");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //textlessonname.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            //textlessonid.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            textlessonname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            textlessonid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


        }
    }
}
