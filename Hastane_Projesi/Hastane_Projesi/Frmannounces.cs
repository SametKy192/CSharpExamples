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
    public partial class Frmannounces : Form
    {
        public Frmannounces()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl=new sqlbaglanti();

        private void Frmannounces_Load(object sender, EventArgs e)
        {
            DataTable dt1=new DataTable();
            SqlDataAdapter dr1 = new SqlDataAdapter("Select * from Tbl_Duyurular", bgl.baglanti());
            dr1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            bgl.baglanti().Close();
             

        }
    }
}
