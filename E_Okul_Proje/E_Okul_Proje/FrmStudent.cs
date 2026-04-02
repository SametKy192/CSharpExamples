using E_Okul_Proje.DataSet1TableAdapters;
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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        Sql_bgl bgl = new Sql_bgl(); 
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            cmbclub.SelectedIndex = -1;
            SqlCommand cmd = new SqlCommand("Select * from TBLKLUPLER", bgl.baglanti());
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbclub.DisplayMember = "KLUPAD"; // gozeuekcek ıtem
            cmbclub.ValueMember = "KLUPID";
            cmbclub.DataSource= dt;
            
            bgl.baglanti().Close();

            


            //  SqlCommand komut2 = new SqlCommand("Select KLUPAD From TBLKLUPLER", bgl.baglanti());
            // SqlDataReader dr2 = komut2.ExecuteReader();
            //while (dr2.Read())
            //{
            //  cmbclub.Items.Add(dr2[0]);
            //}
            //dr2.Close();
            //bgl.baglanti().Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        
        }
        string c = "";

        private void btnadd_Click(object sender, EventArgs e)
        {
           

          
            ds.OgrenciEkle(textstudentname.Text,textstudentname.Text,byte.Parse(cmbclub.SelectedValue.ToString()),c);
            MessageBox.Show("Student Added");
        }

        private void cmbclub_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  textstudentid.Text=cmbclub.SelectedValue.ToString();
        
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ds.OgrenciSilme(int.Parse(textstudentid.Text));
            MessageBox.Show("Student Deleted");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            textstudentid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textstudentname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textsurname.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbclub.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "Erkek")
            {
                radioman.Checked = true;
                c = "Erkek";
            }
             if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "Kız")
            {
                radiowoman.Checked = true;
                c = "Kız";
            }



        }

        private void radioman_CheckedChanged(object sender, EventArgs e)
        {
            if (radioman.Checked == true)
            {
                c = "Erkek";
            }
        }

        private void radiowoman_CheckedChanged(object sender, EventArgs e)
        {


            if (radiowoman.Checked == true)
            {
                c = "Kadın";
            }
       


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(textstudentname.Text, textsurname.Text, byte.Parse(cmbclub.SelectedValue.ToString()), c,int.Parse(textstudentid.Text)) ;
            MessageBox.Show("Student Updated");
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ds.Ogrencigetir(textsearchname.Text);
        }
    }
}
