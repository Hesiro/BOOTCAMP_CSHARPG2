using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio1_BEFORE
{
    internal class SimplePrinter : IPrinterTask
    {
        public void Fax(string content)
        {
            Console.WriteLine($"SP no puedo ralizar FAX");
        }

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
