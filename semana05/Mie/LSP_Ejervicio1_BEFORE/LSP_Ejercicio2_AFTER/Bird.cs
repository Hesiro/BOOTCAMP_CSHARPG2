﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio2_AFTER
{
    internal class Bird : Animal, ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
