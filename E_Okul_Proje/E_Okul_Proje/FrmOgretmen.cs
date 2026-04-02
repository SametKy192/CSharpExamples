using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace E_Okul_Proje
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }
        Sql_bgl bgl= new Sql_bgl();
        public string numara;
        private void FrmOgretmen_Load(object sender, EventArgs e)
        {

            SqlCommand komut2 = new SqlCommand("Select OGRTADSOYAD From TBLOGRETMENLER where OGRTID=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", numara);
            SqlDataReader rdr = komut2.ExecuteReader();
            while (rdr.Read())
            {
                this.Text =  rdr[0].ToString();
            }
            bgl.baglanti().Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup frm =new FrmKulup();
            frm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLessonOGRT frm=new FrmLessonOGRT();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmStudent frm=new FrmStudent();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSınavNotlar frm=new FrmSınavNotlar();
            frm.Show(); this.Hide();
        }
    }
}
