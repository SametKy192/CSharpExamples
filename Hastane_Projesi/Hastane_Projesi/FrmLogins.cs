using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class FrmLogins : Form
    {
        public FrmLogins()
        {
            InitializeComponent();
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            FrmPatientLogin frm = new FrmPatientLogin();
            frm.ShowDialog();
            this.Hide();
        }

        private void btndoctorlogin_Click(object sender, EventArgs e)
        {
            FrmDoctorsLogin frm = new FrmDoctorsLogin();
            frm.ShowDialog();
            this.Hide();    
        }

        private void btnsecretarylogin_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin frm = new FrmSecretaryLogin();
            frm.ShowDialog();   
            this.Hide();
        }

        private void FrmLogins_Load(object sender, EventArgs e)
        {

        }
    }
}
