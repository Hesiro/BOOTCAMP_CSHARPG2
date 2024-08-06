using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider_Before
{
    public class SandwitchAssemble
    {
        private SandwitchBuilder _builder;
        public SandwitchAssemble(SandwitchBuilder builder)
        {
            _builder = builder;
        }

        public void Assembly() {
            _builder.AddPan();
            _builder.AddVerduras();
            _builder.AddProteina();
            _builder.AddCondimentos();
            _builder.AddQueso();
        }  
        
        public Sandwitch GetSandwitch { 
            get { return _builder.Sandwitch; }
        }
    }
}
