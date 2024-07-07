using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio_AFTER
{
    public interface IPlayer
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public PlayerCategory PlayerCategory { get; set; }

        public void SetCategory(PlayerCategory playerCategoty);
        
    }
}
