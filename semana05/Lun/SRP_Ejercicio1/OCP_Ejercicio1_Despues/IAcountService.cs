using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Ejercicio1_Despues
{
    public interface IAcountService
    {
        Staff Create(IPerson Iperson);
    }
}
