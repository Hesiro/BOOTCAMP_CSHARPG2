using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejervicio1_BEFORE
{
    public class TennisPlayer: Player
    {
        public override void AssignTeam(Team team)
        {
            throw new NotImplementedException("Soy un jugador de tenis y no necesito un equipo para jugar");
        }
    }
}
