using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio2_AFTER
{
    public class Animal : IAnimal
    {
        public string Noise { get ; set ; }

        public void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
    }
}
