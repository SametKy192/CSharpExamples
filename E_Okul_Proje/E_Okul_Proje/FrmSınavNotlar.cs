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
    public partial class FrmSınavNotlar : Form
    {
        public FrmSınavNotlar()
        {
            InitializeComponent();
        }
    


        DataSet1TableAdapters.TBLNOTLARTableAdapter ds=new DataSet1TableAdapters.TBLNOTLARTableAdapter();
        Sql_bgl bgl= new Sql_bgl();
        private void btnsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotlarListe(int.Parse(textstudentid.Text));
        }

        private void FrmSınavNotlar_Load(object sender, EventArgs e)
        {
            cmblesson.SelectedIndex = -1;
            SqlCommand cmd = new SqlCommand("Select * from TBLDERSLER", bgl.baglanti());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmblesson.DisplayMember = "DERSAD"; 
            cmblesson.ValueMember = "DERSID";
            cmblesson.DataSource = dt;

            bgl.baglanti().Close();
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmblesson.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;

            textstudentid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textexam1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textexam2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textexam3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textproject.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textavg.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            textstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

        }
     public   int exam1, exam2, exam3, project;
        private void btncalculate_Click(object sender, EventArgs e)
        {
          
            exam1 =Convert.ToInt32(textexam1.Text);
            exam2 = Convert.ToInt32(textexam2.Text);
            exam3 = Convert.ToInt32(textexam3.Text);
            project = Convert.ToInt32(textproject.Text);

            int result = (exam1+ exam2+exam3+ project)/4;
            textavg.Text = result.ToString();
            if (result>50 && result<100)
            {
                textstatus.Text = "True";
            }

            if(result>0 && result<50)
            {
                textstatus.Text = "False";
            }

              
           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textstudentid.Text = "";
            cmblesson.SelectedIndex = -1;
            textexam1.Text = "";
            textexam2.Text = "";
            textexam3.Text = "";
            textproject.Text = "";
            textavg.Text = "";
            textstatus.Text = "";

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmblesson.SelectedValue.ToString()),int.Parse(textstudentid.Text) ,byte.Parse(textexam1.Text),byte.Parse(textexam2.Text), byte.Parse(textexam3.Text), byte.Parse(textproject.Text),decimal.Parse(textavg.Text), bool.Parse(textstatus.Text),notid);
        }
    }
}
