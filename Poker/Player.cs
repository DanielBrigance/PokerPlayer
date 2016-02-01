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
        private bool livePlayer; //human or AI player

        //Constructor for live player
        public Player(String playerName)
        {
            this.playerName = playerName;
            livePlayer = true;
            //Need to open the file associated with the player
        }

        //Constructor for AI player
        public Player()
        {
            playerName = "Danner";
            livePlayer = false;
        }
    }
}
