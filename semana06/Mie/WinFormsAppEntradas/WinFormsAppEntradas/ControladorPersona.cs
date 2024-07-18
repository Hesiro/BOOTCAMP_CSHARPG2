using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppEntradas
{
    public class ControladorPersona
    {
        List<Datos> datos;
        public ControladorPersona()
        {
                datos = new List<Datos>();
        }

        public void Agregar(Datos dato)
        {
            datos.Add(dato);
        }

        public List<Datos> GetDatos() { 
            return datos;
        }

        public Datos GetDatosLast() {
            return datos.Last();
        }
    }
}
