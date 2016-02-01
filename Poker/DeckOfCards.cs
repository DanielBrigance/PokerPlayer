using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class DeckOfCards
    {
        private List<int> deck = new List<int>(); //deck of 52 cards
        private int r1, r2; //random numbers used in shuffling
        private Random rand = new Random();


        //This method builds a deck of cards numbered 1 to 52
        public void populateDeck()
        {
            for (int i = 1; i <= 52; i++)
            {
                deck.Add(i);
            }
        }

        //This methd shuffles the deck 4 times by generating two non-equal integers
        //between 0 and 51 and then swapping the cards at those positions within
        //the deck.  It does this 208 times (52 * 4).
        public void shuffleDeck()
        {
            int temp;
            for (int i = 0; i <= 208; i++) //shuffles 4 times
            {
                r1 = rand.Next(0, 52); //numbers 0 to 51
                r2 = rand.Next(0, 52); //numbers 0 to 51
                while (r1 == r2)
                {
                    r2 = rand.Next(0, 52); //numbers 0 to 51
                }
                temp = deck[r1];
                deck[r1] = deck[r2];
                deck[r2] = temp;
            }
        }

        //This method prints out the cards.
        public void printCards()
        {
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(deck[i]);
            }
        }

        //This method empties the deck and repopulates it.
        public void resetDeck()
        {
            deck.Clear();
            populateDeck();
            shuffleDeck();
        }

        //This method returns the value of the first card and removes it from the deck.
        public int dealCard()
        {
            int topCard = deck[0]; //get top card
            deck.RemoveAt(0); //remove the top card from the deck
            return topCard; //return the top card value
        }
    }
}
