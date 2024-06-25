using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Coche: IVehiculo
    {
        public int velocidad;

        public Coche()
        {
            this.velocidad = 0;
        }

        public void Acelerar(int incremento)
        {
            this.velocidad += incremento;
            Console.WriteLine($"El coche ha acelerado a {velocidad} km/h");
        }

        public void Arrancar()
        {
            Console.WriteLine("El coche ha arrancado.");
        }

        public void Detener()
        {
            Console.WriteLine("El coche se ha detenido.");
        }

        public void Frenar(int decremento)
        {
            this.velocidad -= decremento;
            Console.WriteLine($"El coche ha frenado a {velocidad} km/h");
        }
    }
}
