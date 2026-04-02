using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Frm_Ornek
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db=new DbEntityUrunEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {

            label2.Text=db.TBLKATEGORI.Count().ToString();
            label3.Text = db.TBLURUN.Count().ToString();
            label5.Text=db.TBLMUSTERILER.Count(x=> x.DURUM==true).ToString();
            label7.Text = db.TBLMUSTERILER.Count(x => x.DURUM == false).ToString();
            label13.Text = db.TBLURUN.Sum(y =>y.STOK).ToString();
            label11.Text=(from x in db.TBLURUN orderby x.FIYAT
                descending select x.URUNAD).FirstOrDefault();

            label9.Text = (from x in db.TBLURUN
                            orderby x.FIYAT
                ascending
                            select x.URUNAD).FirstOrDefault();

            label23.Text=(from x in db.TBLMUSTERILER select x.SEHIR).Distinct().Count().ToString();
            label15.Text=db.TBLURUN.Count(x =>x.KATEGORI==1).ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
