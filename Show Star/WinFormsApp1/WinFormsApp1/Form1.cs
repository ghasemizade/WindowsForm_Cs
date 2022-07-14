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
            int star = Convert.ToInt32(textBox1.Text);

            for (int counter = 1; counter <= star; counter++)
            {
                txtRes.Text = "*" +  counter.ToString();
            }
        }
    }
}