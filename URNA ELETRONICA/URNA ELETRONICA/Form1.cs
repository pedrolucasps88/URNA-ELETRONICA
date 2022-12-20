namespace URNA_ELETRONICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += " 0 ";
            Console.Beep(1200,300);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " 1 ";
            Console.Beep(1100,300);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " 2 ";
            Console.Beep(1000, 300);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " 3 ";
            Console.Beep(900, 300);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " 4 ";
            Console.Beep(800, 300);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " 5 ";
            Console.Beep(700, 300);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " 6 ";
            Console.Beep(600, 300);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " 7 ";
            Console.Beep(500, 300);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " 8 ";
            Console.Beep(400, 300);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " 9 ";
            Console.Beep(300, 300);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 9;
            if (textBox1.TextLength== textBox1.MaxLength)
            {
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible= true;
            }
            else
            {
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}