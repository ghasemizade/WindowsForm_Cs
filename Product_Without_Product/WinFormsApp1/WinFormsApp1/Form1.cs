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
            int pro1 = 0;
            for (int counter = 1; counter <= num2; counter++)
            {
                pro1 += num1;
            }
            MessageBox(pro1.ToString());
        }
    }
}