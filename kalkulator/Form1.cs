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
                    if (!flaga)
                    {
                        textBox1.Text += "1";
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Text += "1";
                        flaga = false;
                    }
                    break;
                case "2":
                    if (!flaga)
                    {
                        textBox1.Text += "2";
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Text += "2";
                        flaga = false;
                    }
                    break;
                case "3":
                    if (!flaga)
                    {
                        textBox1.Text += "3";
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Text += "3";
                        flaga = false;
                    }
                    break;
                case "4":
                    if (!flaga)
                    {
                        textBox1.Text += "4";
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Text += "4";
                        flaga = false;
                    }
                    break;
                case "5":
                    if (!flaga)
                    {
                        textBox1.Text += "5";
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Text += "5";
                        flaga = false;
                    }
                    break;
                case "6":
                    if (!flaga)
                    {
                        textBox1.Text += "6";
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Text += "6";
                        flaga = false;
                    }
                    break;
                case "7":
                    if (!flaga)
                    {
                        textBox1.Text += "7";
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Text += "7";
                        flaga = false;
                    }
                    break;
                case "8":
                    if (!flaga)
                    {
                        textBox1.Text += "8";
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Text += "8";
                        flaga = false;
                    }
                    break;
                case "9":
                    if (!flaga)
                    {
                        textBox1.Text += "9";
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Text += "9";
                        flaga = false;
                    }
                    break;
                case "0":
                    if (!flaga)
                    {
                        textBox1.Text += "0";
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Text += "0";
                        flaga = false;
                    }
                    break;
                case "+":
                    if (czy_bufor_pusty)
                    {
                        Bufor1 = textBox1.Text;
                        dzialanie = 1;
                        number1 = Int32.Parse(Bufor1);
                        flaga = true;
                        czy_bufor_pusty = false;
                        //MessageBox.Show("Odejmowanie");
                        //Console.WriteLine(Bufor1);
                        //textBox1.Text = Bufor1;
                    }
                    break;
                case "-":
                    //textBox1.Text += "-";
                    if (czy_bufor_pusty)
                    {
                        Bufor1 = textBox1.Text;
                        dzialanie = 2;
                        number1 = Int32.Parse(Bufor1);
                        flaga = true;
                        czy_bufor_pusty = false;
                        //MessageBox.Show("Odejmowanie");
                        //Console.WriteLine(Bufor1);
                        //textBox1.Text = Bufor1;
                    }
                    break;
                case "*":
                    if (czy_bufor_pusty)
                    {
                        Bufor1 = textBox1.Text;
                        number1 = Int32.Parse(Bufor1);
                        string numuer1_test_probny = number1.ToString();
                        // po zczytaniu liczby zamieniasz j¹ na liczbê poprzez liniê 185
                        //przeprowadzasz w³aœciwe zdia³ania
                        // zamieniasz wynik na test aby móc go wyswietliæ, tak jak w linii 186

                        //MessageBox.Show(numuer1_test_probny);

                        dzialanie = 4;
                        flaga = true;
                        czy_bufor_pusty = false;
                        //MessageBox.Show("Odejmowanie");
                        //Console.WriteLine(Bufor1);
                        //textBox1.Text = Bufor1;
                    }
                    break;
                case "/":
                    if (czy_bufor_pusty)
                    {
                        Bufor1 = textBox1.Text;
                        dzialanie = 3;
                        number1 = Int32.Parse(Bufor1);
                        flaga = true;
                        czy_bufor_pusty = false;
                        //MessageBox.Show("Odejmowanie");
                        //Console.WriteLine(Bufor1);
                        //textBox1.Text = Bufor1;
                    }
                    break;
                case "=":
                    Bufor2 = textBox1.Text;
                    number2 = Int32.Parse(Bufor2);
                    string wynik_teskt;
                    switch (dzialanie)
                    {
                        case 1:
                            wynik = number1 + number2;
                            //wynik = 4;
                            wynik_teskt = wynik.ToString();
                            //zamiana int na string
                            textBox1.Text = wynik_teskt;
                            break;
                        case 2:
                            wynik = number1 - number2;
                            //wynik = 4;
                            wynik_teskt = wynik.ToString();
                            //zamiana int na string
                            textBox1.Text = wynik_teskt;
                            break;
                        case 3:
                            wynik = number1 / number2;
                            //wynik = 4;
                            wynik_teskt = wynik.ToString();
                            //zamiana int na string
                            textBox1.Text = wynik_teskt;
                            break;
                        case 4:
                            wynik = number1 * number2;
                            //wynik = 4;
                            wynik_teskt = wynik.ToString();
                            //zamiana int na string
                            textBox1.Text = wynik_teskt;
                            break;
                    }
                    //number1 = wynik;
                    flaga = true;
                    czy_bufor_pusty = true;

                    break;
                    //break;
                    //if {case "="
            }
            //}
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Bufor1 = "";
            Bufor2 = "";
            number1 = 0;
            number2 = 0;
            flaga = false;
            czy_bufor_pusty = true;
            //textBox1.Text = "";
            textBox1.Text = null;

        }


    }
}