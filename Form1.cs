namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = (Math.Sin((Math.PI / 2) + 3 * double.Parse(textBox1.Text)) / 1 - Math.Sin(3 * double.Parse(textBox1.Text) - Math.PI)).ToString(); ;
            textBox3.Text = (1 / Math.Tan(5 / 4 * Math.PI + 3 / 2 * double.Parse(textBox1.Text))).ToString(); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
