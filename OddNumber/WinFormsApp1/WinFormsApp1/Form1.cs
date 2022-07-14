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
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int sum2 = 1;
            int sum1 = 1;

            if (num1 > num2)
            {
                for (int counter = num2; counter < num1; counter++)
                {
                    if (counter % 2 == 1)
                    {
                        sum1 *= counter;
                    }
                }
                MessageBox.Show(sum1.ToString());
            }
            if (num1 < num2)
            {
                for (int counter = num1; counter < num2; counter++)
                {
                    if (counter % 2 == 1)
                    {
                        sum2 *= counter;
                    }
                }
                MessageBox.Show(sum2.ToString());
            }
        }
    }
}