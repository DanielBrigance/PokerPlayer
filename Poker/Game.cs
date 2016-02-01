using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Game
    {
        private int smallBlind, bigBlind; //amount of small and big blinds
        private List<Player> players = new List<Player>(); //List of Players
        public Dictionary<int, StartingHand> startingHands = new Dictionary<int, StartingHand>(); //Dictionary from unique int to StartingHand object

        //Constructor for Game. Populates players.  
        public Game(int numPlayers, int playerPos)
        {
            /*
             *  Issues here: 
             *  Positions need to be randomized in interface before this is ran.
             *  Also, names need to be entered.
             * 
             */
            for(int i = 0; i < numPlayers; i++)
            {
                if(i == playerPos)
                {
                    players.Add(new Player()); //Add computer player
                }
                else
                {
                    players.Add(new Player(getPlayerName(i))); //Add live player
                }
            }
            generateStartingHands();
        }

        private String getPlayerName(int position)
        {
            //Get player name from interface for player in given position in interface
            return "";
        }

        private void generateStartingHands()
        {
            for (int i = 1; i <= 52; i++)
            {
                for (int j = i + 1; j <= 52; j++)
                {
                    if (i < j) startingHands.Add((i * 100 + j), new StartingHand(i, j));
                    else startingHands.Add((j * 100 + i), new StartingHand(j, i));
                }
            }
        }
    }
}
