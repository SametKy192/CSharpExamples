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
    public partial class FrmDoctorsLogin : Form
    {
        public FrmDoctorsLogin()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl=new sqlbaglanti();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",mskTc.Text);
            cmd.Parameters.AddWithValue("@p2",textPassword.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
                {
                FrmDoctorDetails fr = new FrmDoctorDetails();
                fr.TC=mskTc.Text;
                fr.Show();
            
            }
            else
            {
                MessageBox.Show("Incorrect ID or Password...");
            }
            bgl.baglanti().Close();

           
        }
    }
}
