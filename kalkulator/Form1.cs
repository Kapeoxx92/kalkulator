namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string text = btn.Text;
            switch (text)
            {
                case "1":
                    textBox1.Text += "1";
                    break;
                case "2":
                    textBox1.Text += "2";
                    break;
                case "3":
                    textBox1.Text += "3";
                    break;
                case "4":
                    textBox1.Text += "4";
                    break;
                case "5":
                    textBox1.Text += "5";
                    break;
                case "6":
                    textBox1.Text += "6";
                    break;
                case "7":
                    textBox1.Text += "7";
                    break;
                case "8":
                    textBox1.Text += "8";
                    break;
                case "9":
                    textBox1.Text += "9";
                    break;
                case "0":
                    textBox1.Text += "0";
                    break;
                case "-":
                    textBox1.Text += "-";
                    break;
                case "+":
                    textBox1.Text += "+";
                    break;
                case "*":
                    textBox1.Text += "*";
                    break;
                case "/":
                    textBox1.Text += "/";
                    break;
                    if {case "="
            }
                    }
            }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
    }
}