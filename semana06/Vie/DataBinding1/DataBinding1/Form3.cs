using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            List<Departamento> listDepartamentos = new List<Departamento>();
            Departamento departamento1 = new Departamento("Ingenieria");
            departamento1.Add(new Estudiante("Juan Ortiz","Calle Azufran 441"));
            departamento1.Add(new Estudiante("Maria Flores","Av. Circulacion 508"));
            listDepartamentos.Add(departamento1);
            Departamento departamento2 = new Departamento("Ciencias");
            departamento2.Add(new Estudiante("Pedro Peres", "Calle 4 de mayo"));
            departamento2.Add(new Estudiante("Ana Lopez", "Av. 20 Noviembre 14"));
            listDepartamentos.Add(departamento2);

            BindingSource comboBindingSource = new BindingSource();
            BindingSource listBoxBindingSource = new BindingSource();

            comboBindingSource.DataSource = listDepartamentos;

            listBoxBindingSource.DataSource = comboBindingSource;
            listBoxBindingSource.DataMember = "ListEstudiantes";

            comboBox1.DataSource = comboBindingSource;
            comboBox1.DisplayMember = "NombreDepartamento";

            listBox1.DataSource = listBoxBindingSource;
            listBox1.DisplayMember = "Nombre";

            textBox1.DataBindings.Add("Text", listBoxBindingSource, "Direccion");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
