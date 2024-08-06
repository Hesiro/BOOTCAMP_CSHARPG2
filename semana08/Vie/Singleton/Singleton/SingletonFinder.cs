using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonFinder
    {
        public int GetTotalPopulation(IEnumerable<string> listaCapitales) {
            int total = 0;
            foreach (var poblacion in listaCapitales) 
            {
                total += SingletonContainer.Instance.GetPopulation(poblacion); 
            }
            return total;
        }
    }
}
