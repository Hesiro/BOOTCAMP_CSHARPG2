using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class SandwitchBuilder
    {
        protected Sandwitch _sandwitch = new Sandwitch();

        public Sandwitch Sandwitch => _sandwitch;

        public SandwitchBuilder()
        {
            _sandwitch = new Sandwitch();
        }

        public SandwitchBuilder AddProteina()
        {
            _sandwitch.Proteinas = "Proteina de carne";
            return this;
        }

        public SandwitchBuilder AddQueso() {
            _sandwitch.Queso = "Queso chedar";
            return this;
        }
        public SandwitchBuilder AddCondimento()
        {
            _sandwitch.Condimentos = "Mayonesa";
            return this;
        }
        public SandwitchBuilder AddPan()
        {
            _sandwitch.Pan = "Pan de trigo";
            return this;
        }
        public SandwitchBuilder AddVerduras()
        {
            _sandwitch.Verduras = "Tomate y lechuga";
            return this;
        }
    }
}
