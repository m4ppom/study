using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyRockPaperScissor.Helper
{
    public class Hand
    {
        public OptionRPS Selection { get; set; }
        public OptionRPS WinsAgainst { get; set; }
        public OptionRPS LoseAgainst { get; set; }
        public String Image { get; set; }
        public GameStatus PlayAgainst (Hand opponentHand)
        {
            if(Selection == opponentHand.Selection)
            {
                return GameStatus.Nothing;
            }
            if (LoseAgainst == opponentHand.Selection)
            {
                return GameStatus.Defeat;
            }
            return GameStatus.Victory;
        }
    }
}
