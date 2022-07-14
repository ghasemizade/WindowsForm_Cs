namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);

            for (int counter = 1; counter <= number; counter++)
            {
                if (number % counter == 0)
                {
                    MessageBox.Show(counter.ToString());
                }
            }
        }
    }
}