using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio_AFTER
{
    public class FootballPlayer : Player, IPlayerTeam
    {
        public Team Team { get ; set ; }

        public void AssignTeam(Team team)
        {
            Team = team;
        }

        public string GetTeam()
        {
            return Team.Name;
        }

        public string GetMarketValue(PlayerCategory playerCategory)
        {
            string marketValue = string.Empty;
            switch (playerCategory)
            {
                case PlayerCategory.Professional:
                    marketValue = "1000";
                    break;
                case PlayerCategory.Amateur:
                    marketValue = "100";
                    break;
            }
            return marketValue;
        }
    }
}
