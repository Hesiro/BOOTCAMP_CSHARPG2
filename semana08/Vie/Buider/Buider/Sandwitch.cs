using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider_Before
{
    public class Sandwitch
    {

        public string Pan { get; set; }
        public string Verduras { get; set; }
        public string Proteina { get; set; }
        public string Condimentos { get; set; }
        public string Queso { get; set; }
        public Sandwitch()
        {
            
        }
        public Sandwitch(string pan, string verduras, string proteina, string condimentos, string queso)
        {
            Pan = pan;
            Verduras = verduras;
            Proteina = proteina;
            Condimentos = condimentos;
            Queso = queso;
        }
    }
}
