using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio2_BEFORE
{
    public class Animal
    {
        public virtual void MakeNoise()
        {
            Console.WriteLine("Make noise...");
        }
        public virtual void Fly() {
            Console.WriteLine("I'm flying");
        }
    }
}
