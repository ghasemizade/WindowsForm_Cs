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
            int number = Convert.ToInt32(textBox1.Text);
            float pi = 3.14F;

            double circumference = 2 * pi * number;
            pi = Convert.ToInt64(circumference / number);

            MessageBox.Show(pi.ToString());
        }
    }
}