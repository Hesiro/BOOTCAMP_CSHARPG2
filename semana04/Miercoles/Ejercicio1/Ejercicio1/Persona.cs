using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Persona
    {
        public string nombre;
        public DateTime fechaNacimiento;
        private int edad;

        public void Registrar() {
            CalcularEdad(fechaNacimiento);
            Console.WriteLine($"{nombre} Se procedio la ");
        }

        private void CalcularEdad(DateTime fechaNacimientoPersona)
        {
            DateTime fechaActual = DateTime.Now;
            edad = fechaActual.Year - fechaNacimientoPersona.Year;
        }
    }
}
