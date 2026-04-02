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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db=new DbEntityUrunEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            var kategoriler=db.TBLKATEGORI.ToList();
            dataGridView1.DataSource= kategoriler;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI tk=new TBLKATEGORI();
            tk.AD = textBox2.Text;
            db.TBLKATEGORI.Add(tk);
            db.SaveChanges();
            MessageBox.Show("Eklendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
           int x=Convert.ToInt32(textBox1.Text);
            var ktsil=db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(ktsil);
            db.SaveChanges();
            MessageBox.Show("Silindi");

                 
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktguncelle = db.TBLKATEGORI.Find(x);
            ktguncelle.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Guncellendı");

        }
    }
}
