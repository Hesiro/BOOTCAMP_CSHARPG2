using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio2_BEFORE
{
    public class Dog: Animal
    {
        public override void Fly()
        {
            throw new NotImplementedException("I'm a dog, i can't fly.");            
        }
    }
}
