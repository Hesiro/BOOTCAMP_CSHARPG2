using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio1_AFTER
{
    public class HPLaserJetPrinter : IFax, IPrint, IScan
    {
        public void Fax(string content)
        {
            Console.WriteLine($"HP Fax: {content}");
        }

        public void Print(string content)
        {
            Console.WriteLine($"HP Print: {content}");
        }

        public void Scan(string content)
        {
            Console.WriteLine($"HP Scan: {content}");
        }
    }
}
