namespace WinFormsAppEntradas
{
    public partial class FormEntornoGrafico : Form
    {
        ControladorPersona controla;
        //List<Datos> miLista;
        //Datos dato;
        public FormEntornoGrafico()
        {
            InitializeComponent();
            //miLista = new List<Datos>();
            controla = new ControladorPersona();
            //dato = new Datos();
        }

        private void FormEntornoGrafico_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = string.Empty;
            textBoxApellido.Text = string.Empty;
            textBoxEdad.Text = "0";
            textBoxDireccion.Text = string.Empty;
            comboBoxGenero.Text = string.Empty;
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            controla.Agregar(
                new Datos
                {
                    Nombre = textBoxNombre.Text,
                    Apellido = textBoxApellido.Text,
                    Edad = Convert.ToInt32(textBoxEdad.Text),
                    Direccion = textBoxDireccion.Text,
                    Genero = comboBoxGenero.SelectedItem.ToString()
                });
            MessageBox.Show($"Se agregó los datos. {textBoxNombre.Text} {textBoxApellido.Text}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPantallaTres_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Personas = controla.GetDatos();
            frm3.ShowDialog();
        }

        private void buttonPantallaDos_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Persona = controla.GetDatosLast();
            frm2.ShowDialog();
        }
    }
}
