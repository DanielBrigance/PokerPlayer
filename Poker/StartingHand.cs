using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class StartingHand
    {
        private int lowCard, highCard; //The two cards for this starting hand
        private bool suited; //Suited or not
        private int rank; //Rank of this hand

        public StartingHand(int lowCard, int highCard)
        {
            this.lowCard = lowCard;
            this.highCard = highCard;
            suited = ((lowCard / 13) == (highCard / 13));
            rank = setRank();
        }

        //This method sets the rank of the card
        private int setRank()
        {
            //TODO Build ranking system.
            return 1;
        }
    }
}
