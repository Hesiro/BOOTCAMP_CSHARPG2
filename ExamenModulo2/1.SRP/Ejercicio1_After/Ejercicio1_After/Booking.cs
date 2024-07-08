using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public class Booking
    {
        public Usuario Usuario { get; set; }
        public DateTime CheckIn {  get; set; }
        public DateTime CheckOut { get; set; }
    }
}
