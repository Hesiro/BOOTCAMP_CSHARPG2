using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio1_BEFORE
{
    public interface IPrinterTask
    {
        void Fax(string content);
        void Print(string content);
        void Scan(string content);
    }
}
