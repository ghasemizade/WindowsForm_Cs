namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numX = Convert.ToInt32(textBox1.Text);
            int numY = Convert.ToInt32(textBox2.Text);
            double powXY = Math.Pow(numX, numY);

            MessageBox.Show(powXY.ToString());
        }
    }
}