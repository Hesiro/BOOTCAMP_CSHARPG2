using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio1_AFTER
{
    internal class SimplePrinter: IPrint, IScan
    {
        public void Print(string content)
        {
            Console.WriteLine($"SP Print: {content}");
        }

        public void Scan(string content)
        {
            Console.WriteLine($"SP Scan: {content}");
        }
    }
}
