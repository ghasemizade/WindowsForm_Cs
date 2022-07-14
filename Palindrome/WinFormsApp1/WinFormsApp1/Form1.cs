namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inputuser = Convert.ToInt32(textBox1.Text);

            int Tempnumber = inputuser;
            int mod;
            int revers = 0;

            if (inputuser < 0)
            {
                MessageBox.Show("false");
            }

            while (inputuser != 0)
            {
                mod = inputuser % 10;
                revers = revers * 10 + mod;
                inputuser /= 10;
            }
            if (Tempnumber == revers)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }
        }
    }
}