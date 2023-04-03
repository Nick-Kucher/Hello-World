namespace lab_2_OPI
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double result = Math.PI * a * b;
            label5.Text=result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}