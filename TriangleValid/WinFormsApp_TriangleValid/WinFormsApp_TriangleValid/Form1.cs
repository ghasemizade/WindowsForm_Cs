namespace WinFormsApp_TriangleValid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sideA = Convert.ToInt32(textBox1.Text);
            int sideB = Convert.ToInt32(textBox2.Text);
            int sideC = Convert.ToInt32(textBox3.Text);

            if (sideA + sideB > sideC && sideA + sideC > sideB && sideC + sideB > sideA)
            {
               MessageBox.Show("this numbers create triangle :)");
            }
            else
            {
                MessageBox.Show("this numbers does not create triangle !");
            }
        }
    }
}