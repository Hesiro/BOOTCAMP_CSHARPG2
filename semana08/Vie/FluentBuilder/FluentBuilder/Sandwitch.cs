using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class Sandwitch
    {
        public string Pan { get; set; }
        public string Verduras { get; set; }
        public string Proteinas { get; set; }
        public string Queso { get; set; }
        public string Condimentos { get; set; }

        public Sandwitch()
        {
            
        }

        public Sandwitch(string pan, string verduras, string proteinas, string queso, string condimentos)
        {
            Pan = pan;
            Verduras = verduras;
            Proteinas = proteinas;
            Queso = queso;
            Condimentos = condimentos;
        }
    }
}
