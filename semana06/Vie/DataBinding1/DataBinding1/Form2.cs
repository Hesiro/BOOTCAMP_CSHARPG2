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
    public partial class Form2 : Form
    {
        List<Universidad> universidadList = new List<Universidad>();
        BindingSource bindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            universidadList.Add(new Universidad("Universidad Peruana de Ciencias Aplicadas", "UPC", "Av. Salaverry 2255, San Isidro"));
            universidadList.Add(new Universidad("Universidad Nacional de Ingenieria", "UNI", "Av. Tupac Amaru 210, Rimac"));
            universidadList.Add(new Universidad("Universidad Mayor de San Marcos","UNMSM","Av. Venezuela s/n, Cercado de Lima"));
            universidadList.Add(new Universidad("Pontificie Universidad Católica del Perú", "PUCP", "Av. La Fontana, La Molina"));

            bindingSource.DataSource = universidadList;

            comboBox1.DataSource = bindingSource;
            comboBox1.DisplayMember = "Acronimo";

            textBox1.DataBindings.Add("Text", bindingSource, "Nombre");
            textBox2.DataBindings.Add("Text", bindingSource, "Direccion");
        }
    }
}
