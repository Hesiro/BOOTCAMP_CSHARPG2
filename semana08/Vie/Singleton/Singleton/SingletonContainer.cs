using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonContainer : ISingletonContainer
    {
        private Dictionary<string, int> _capitales = new Dictionary<string, int>();

        //public SingletonContainer()
        private SingletonContainer()
        {
            var elementos = File.ReadAllLines("Capitales.txt");
            for (int i = 0; i < elementos.Length; i += 2)
            {
                _capitales.Add(elementos[i], int.Parse(elementos[i + 1]));
            }

        }
        public int GetPopulation(string name)
        {
            return _capitales[name];
        }

        private static Lazy<SingletonContainer> _instance = new Lazy<SingletonContainer>(() => new SingletonContainer());
        public static SingletonContainer Instance => _instance.Value;
    }
}
