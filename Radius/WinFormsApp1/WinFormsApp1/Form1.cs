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
            float pi = 3.14F;
            float radius;
            radius = Convert.ToInt32(textBox1.Text);
            float environment, area, diameter;
            environment = 2 * pi * radius;
            area = pi * radius * radius;
            diameter = radius * 2;
            txtRes.Text = "environment :" + environment.ToString() +","+ "area : " + area.ToString() +","+ "diameter " + diameter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}