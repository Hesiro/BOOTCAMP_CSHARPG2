namespace WinFormsAppIntroduccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnSaluda_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Bienvenido {txtFirstName.Text} {txtSecondName.Text}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
        }
    }
}
