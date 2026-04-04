namespace Point_konum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point konum= new Point();
            konum.X = 100;
            konum.Y = 350;

            pictureBox1.Location=konum;
        }
    }
}
