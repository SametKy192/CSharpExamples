using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entity_layer;
using DataAcces_Layer;
using Logic_Layer;

namespace n_katmanli_mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel ent =new EntityPersonel();
            ent.Ad=txtad.Text;
            ent.Soyad=txtsoyad.Text;
            ent.Sehir=txtsehir.Text;
            ent.Maas=short.Parse(txtmaas.Text);
            ent.Gorev=txtgorev.Text;

            LogicPersonel.LLPersonel(ent);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent=new EntityPersonel();
            ent.Id=Convert.ToInt32(txtid.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
        }
    }
}
