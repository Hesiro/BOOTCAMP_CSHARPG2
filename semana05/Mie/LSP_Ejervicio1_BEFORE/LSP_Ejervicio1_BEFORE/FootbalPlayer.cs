using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejervicio1_BEFORE
{
    public class FootbalPlayer:Player
    {
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
