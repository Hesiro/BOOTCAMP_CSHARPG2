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
    public partial class Form3 : Form
    {
        List<Datos> personas;
        public Form3()
        {
            InitializeComponent();
            personas = new List<Datos>();
            
        }
        public List<Datos> Personas
        {
            get { return personas; }
            set { personas = value; }
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bindingSourceDatos.DataSource = Personas;
        }
    }
}
