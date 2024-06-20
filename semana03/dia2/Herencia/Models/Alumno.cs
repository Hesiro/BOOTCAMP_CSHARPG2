using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Models
{
    internal class Alumno:Persona
    {
        public int Nota { get; set; }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Tienes una nota de {Nota}");
        }
    }
}
