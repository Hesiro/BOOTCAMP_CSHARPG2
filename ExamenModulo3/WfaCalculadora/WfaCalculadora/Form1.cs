namespace WfaCalculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0;
        double Numero2 = 0;
        char Operador = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AgregarNumero(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (textBoxResultado.Text.Equals("0"))
            {
                textBoxResultado.Text = "";
            }
            textBoxResultado.Text += button.Text;
        }

        private void AgregarOperador(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Numero1 = double.Parse(textBoxResultado.Text);

            if (button.Text == "x^2")
            {
                Numero1 = Math.Pow(Numero1, 2);
                textBoxResultado.Text = Numero1.ToString();
            }
            else if (button.Text == "Æ")
            {
                Numero1 = Math.Sqrt(Numero1);
                textBoxResultado.Text = Numero1.ToString();
            }
            else
            {
                Operador = Convert.ToChar(button.Tag);

                textBoxResultado.Text = "0";
            }
        }





        private void buttonIgual_Click(object sender, EventArgs e)
        {
            Numero2 = double.Parse(textBoxResultado.Text);
            if (Operador == '+')
            {
                textBoxResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(textBoxResultado.Text);
            }
            else if (Operador == '-')
            {
                textBoxResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(textBoxResultado.Text);
            }
            else if (Operador == 'x')
            {
                textBoxResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(textBoxResultado.Text);
            }
            else if (Operador == '/')
            {
                if (textBoxResultado.Text != "0")
                {
                    textBoxResultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(textBoxResultado.Text);
                }
                else
                {
                    textBoxResultado.Text = "Error";
                }
            }
        }

        private void buttonBorrarUltimo_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text.Length > 1)
            {
                textBoxResultado.Text = textBoxResultado.Text.Remove(textBoxResultado.Text.Length - 1, 1);
            }
            else
            {
                textBoxResultado.Text = "0";
            }
        }

        private void buttonBorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = ' ';
            textBoxResultado.Text = "0";
        }

        private void buttonRecorrer_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (!textBoxResultado.Text.Contains("."))
            {
                textBoxResultado.Text += ".";
            }
        }

        private void buttonSigno_Click(object sender, EventArgs e)
        {
            Numero1 = double.Parse(textBoxResultado.Text);
            Numero1 = -Numero1;
            textBoxResultado.Text = Numero1.ToString();
        }
    }
}
