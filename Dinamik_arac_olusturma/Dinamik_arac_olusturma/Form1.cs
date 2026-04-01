using System.Security.Cryptography;

namespace Dinamik_arac_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn=new Button();
            Point btnkonum= new Point(200,100);
            btn.Location= btnkonum;
            btn.Name = "btnyeni";
            btn.Text = "Yeni Buton";
            btn.BackColor = Color.Green;
            btn.Height = 100;
            btn.Width=300;

            Label lbl = new Label();
            Point lblkonum= new Point(20,10);
            lbl.Location= lblkonum;
            lbl.Name = "label1";
            lbl.Text = "Merhaba";
            lbl.BackColor = Color.Orange;


            for(int i = 1; i<=5;i++)
            {

                TextBox txt = new TextBox();
                Point txtkonum = new Point(350,i*30);
                txt.Location= txtkonum;
                txt.Name = "txt1"+i;
                txt.Text=i.ToString();
                this.Controls.Add(txt);

            }


            this.Controls.Add(btn); // bu formun ýcýne ekle kontrolu
            this.Controls.Add(lbl);

          




        }
    }
}
