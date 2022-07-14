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
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Pink);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            formGraphics.DrawLine(pen, 10, 10, 300, 150);
            formGraphics.DrawLine(pen, 10, 10, 10, 150);
            formGraphics.DrawLine(pen, 300, 150, 10, 150);
            myBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}