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
                    MessageBox.Show("No");
                    newtemp = 1;
                    break;
                }
            }
            if (newtemp == 0)
            {
                MessageBox.Show("Yes");
            }
        }
    }
}