using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding1
{
    public class Universidad
    {
        public string Nombre { get; set; }
        public string Acronimo { get; set; }
        public string Direccion { get; set; }

        public Universidad(string nombre, string acronimo, string direccion)
        {
            Nombre = nombre;
            Acronimo = acronimo;
            Direccion = direccion;
        }
    }
}
