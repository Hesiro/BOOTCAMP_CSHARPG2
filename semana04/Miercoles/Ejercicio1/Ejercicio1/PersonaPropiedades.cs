using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public  class PersonaPropiedades
    {
        //atributos
        private string nombre;
        private DateTime fechaNacimiento;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        private int Edad { get => edad; set => edad = value; }

        private void CalcularEdad(DateTime fechaNacimientoPersona)
        {
            DateTime fechaActual = DateTime.Now;
            edad = fechaActual.Year - fechaNacimientoPersona.Year;
        }

        public void Registrar()
        {
            CalcularEdad(fechaNacimiento);
            Console.WriteLine($"{nombre} Se procedio la ");
        }
    }
}
