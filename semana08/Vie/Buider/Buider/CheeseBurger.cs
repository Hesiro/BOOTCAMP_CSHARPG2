using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider_Before
{
    public class CheeseBurger : SandwitchBuilder
    {
        public CheeseBurger()
        {
            sandwitch = new Sandwitch();
        }
        public override void AddCondimentos()
        {
            sandwitch.Condimentos = "Mayonesa";
        }

        public override void AddPan()
        {
            sandwitch.Pan = "Pan de molde";
        }

        public override void AddProteina()
        {
            sandwitch.Proteina = "Proteina A";
        }

        public override void AddQueso()
        {
            sandwitch.Queso = "Queso chedar";
        }

        public override void AddVerduras()
        {
            sandwitch.Verduras = "Tomate, lechuga";
        }
    }
}
