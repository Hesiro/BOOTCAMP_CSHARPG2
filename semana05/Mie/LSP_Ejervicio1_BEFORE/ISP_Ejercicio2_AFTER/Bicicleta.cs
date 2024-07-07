using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Ejercicio2_AFTER
{
    public class Bicicleta: IMove, IGetNumberOfWheel
    {
        public int GetNumberOfWheel()
        {
            return 2;
        }

        public void Move()
        {
            Console.WriteLine("Bicicleta en movimiento");
        }
    }
}
