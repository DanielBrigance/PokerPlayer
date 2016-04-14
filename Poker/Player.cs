using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Player
    {
        private String playerName; //Name of the player
        private int lowCard, highCard;

        //Constructor for live player
        public Player() { }

        public void setPlayerName(String name)
        {
            playerName = name;
        }

        public void setHand(int card1, int card2)
        {
            int card1Mod14 = card1 % 14;
            int card2Mod14 = card2 % 14;
            if (card1Mod14 > card2Mod14)
            {
                if (card2Mod14 != 1) // Card2 not an Ace
                {
                    highCard = card2;
                    lowCard = card1;
                }
            }
            else
            {
                highCard = card1;
                lowCard = card2;
            }
        }
    }
}
