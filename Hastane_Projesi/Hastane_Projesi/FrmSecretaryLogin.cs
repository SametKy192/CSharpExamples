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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl =new sqlbaglanti();

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", textPassword.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSecretaryDetails frdetails = new FrmSecretaryDetails();
                frdetails.TcNumber = mskTc.Text;
                frdetails.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect ID or Password");
            }
            bgl.baglanti().Close();
        }
    }
}
