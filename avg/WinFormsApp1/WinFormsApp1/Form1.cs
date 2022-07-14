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

            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int num3 = Convert.ToInt32(textBox3.Text);
            int num4 = Convert.ToInt32(textBox4.Text);
            double average;
            double sum = num1 + num2 + num3 + num4;
            
            average = sum / 4;
            MessageBox.Show(average.ToString());
        }
    }
}