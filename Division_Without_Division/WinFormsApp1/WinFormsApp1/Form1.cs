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
            int div1 = 0;
            int mod = num1;
            for (int counter = 0; ; counter++)
                if (mod >= num2)
                {
                    div1++;
                    mod -= num2;
                }
                else
                {
                    break;
                }
            MessageBox.Show(div1.ToString());
        }
    }
}