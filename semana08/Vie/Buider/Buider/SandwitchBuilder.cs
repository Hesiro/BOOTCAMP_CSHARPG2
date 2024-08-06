using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider_Before
{
    public abstract class SandwitchBuilder
    {
        protected Sandwitch sandwitch;
        public abstract void AddPan();
        public abstract void AddVerduras();
        public abstract void AddProteina();
        public abstract void AddCondimentos();
        public abstract void AddQueso();

        public Sandwitch Sandwitch { get { return sandwitch; } }
    }
}
