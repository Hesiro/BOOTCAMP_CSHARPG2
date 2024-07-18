namespace WinFormsAppCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtPrimero.Text);
            int num2 = Convert.ToInt32(txtSegundo.Text);
            int suma = num1 + num2;
            txtResultado.Text = suma.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimero.Text = "";
            txtSegundo.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
