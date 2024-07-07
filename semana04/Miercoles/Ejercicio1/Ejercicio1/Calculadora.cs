using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Calculadora
    {
        public void Suma(int valorA,  int valorB)
        {
            int resultado = valorA + valorB;
            Console.WriteLine($"El resulatdo de la suma es: {resultado}");
        }

        public void Suma(double valorA, double valorB)
        {
            double resultado = valorA + valorB;
            Console.WriteLine($"El resulatdo de la suma es: {resultado}");
        }
    }
}
