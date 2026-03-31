namespace captcha_and_random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] sembol1 = { "a", "b", "c", "d" };
            string[] sembol2 = { "!", "+", "%", "?" };

            Random rndm = new Random();
            int s1, s2, s3;
            s1 = rndm.Next(0, sembol1.Length);
            s2 = rndm.Next(0, sembol2.Length);
            s3 = rndm.Next(0, 10);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
           // this.Hide(); form 1i saklar
        }
    }
}
