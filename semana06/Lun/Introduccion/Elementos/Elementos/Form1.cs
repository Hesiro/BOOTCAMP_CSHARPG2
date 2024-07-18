namespace Elementos
{
    public partial class FormElementos : Form
    {
        public FormElementos()
        {
            InitializeComponent();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if (checkBoxFemenino.Checked && checkBoxMasculino.Checked)
            {
                labelPrueba.Text = "Masculino y Femenino";
            }
            else
            {
                if (checkBoxFemenino.Checked)
                {
                    labelPrueba.Text = "Femenino";
                }
                else
                {
                    if (checkBoxMasculino.Checked)
                    {
                        labelPrueba.Text = "Masculino";
                    }
                    else
                    {
                        labelPrueba.Text = "Ninguno";
                    }
                }
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelEstadoCivil.Text = "Soltero";
        }

        private void radioButtonCasado_CheckedChanged(object sender, EventArgs e)
        {
            labelEstadoCivil.Text = "Casado";
        }

        private void radioButtonDivorciado_CheckedChanged(object sender, EventArgs e)
        {
            labelEstadoCivil.Text = "Divorciado";
        }

        private void FormElementos_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonArequipa_CheckedChanged(object sender, EventArgs e)
        {
            labelCiudad.Text = "Arequipa";
        }

        private void radioButtonLima_CheckedChanged(object sender, EventArgs e)
        {
            labelCiudad.Text = "Lima";
        }

        private void radioButtonCuzco_CheckedChanged(object sender, EventArgs e)
        {
            labelCiudad.Text = "Cuzco";
        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {
            labelGenero.Text = "Masculino";
        }

        private void radioButtonFemenino_CheckedChanged(object sender, EventArgs e)
        {
            labelGenero.Text = "Femenino";
        }

        private void comboBoxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPais.Text = comboBoxPais.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Hola");
        }

        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ListBox - " + (++i).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value += 10;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToShortDateString();
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
                label1.ForeColor = Color.Red;
            else label1.ForeColor = Color.Black;
        }
    }
}
