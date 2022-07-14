namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            double pow1 = Math.Pow(num, 1);
            double pow2 = Math.Pow(num, 2);
            double pow3 = Math.Pow(num, 3);

            txtRes.Text = "Power of 1:"+ pow1.ToString()+","+"Power of 2:"+ pow2.ToString()+","+ "Power of 3:"+ pow3.ToString();
        }
    }
}