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
            int inputuser = Convert.ToInt32(textBox1.Text);
            int sum = 0;
            int temp = inputuser / 2;
            int newtemp = 0;
            for (int counter = 2; counter <= temp; counter++)
            {
                if (inputuser % counter == 0)
                {
                    sum += counter;
                }
            }
            if (sum == inputuser)
            {
                MessageBox.Show("this number is tom :)");
            }
            else
            {
                MessageBox.Show("this not tom number !");
            }

        }
    }
}