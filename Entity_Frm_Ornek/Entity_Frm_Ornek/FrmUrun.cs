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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = (from x in db.TBLURUN select new
            {
               x.URUNID ,
                x.URUNAD,
                x.MARKA,
                x.STOK,
                x.FIYAT,
                x.DURUM,
                x.TBLKATEGORI.AD


            }).ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txtad.Text;
            t.MARKA = txtmarka.Text;
            t.STOK = int.Parse(txtstok.Text);
            t.FIYAT = decimal.Parse(txtfiyat.Text);
            t.KATEGORI = int.Parse(cmbkategori.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Sisteme kaydedildi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //   TBLURUN t = new TBLURUN(); ekleme  kullanırız
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Silindi");

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urunguncelle = db.TBLURUN.Find(x);
            urunguncelle.URUNAD = txtad.Text;
            urunguncelle.MARKA = txtmarka.Text;
            urunguncelle.STOK = int.Parse(txtstok.Text);
            db.SaveChanges();


            MessageBox.Show("Guncellendı");


        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kateogriler = (from x in db.TBLKATEGORI 
                               select new 
                               { 
                                   x.ID, x.AD 
                               }
                               ).ToList();
            

            cmbkategori.ValueMember = "ID";// gozukmeyecek kısım
            cmbkategori.DisplayMember = "Ad";
            cmbkategori.DataSource = kateogriler;
        }
    }
}
