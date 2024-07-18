using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppEntradas
{
    public partial class Form2 : Form
    {
        Datos persona;
        public Form2()
        {
            InitializeComponent();
            persona = new Datos();
        }

        public Datos Persona
        {
            get { return persona; }
            set { persona = value; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            labelNombre.Text = Persona.Nombre;
            labelApellido.Text = Persona.Apellido;
            labelEdad.Text = Persona.Edad.ToString();
            labelDireccion.Text = Persona.Direccion;
            labelGenero.Text = Persona.Genero;

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
