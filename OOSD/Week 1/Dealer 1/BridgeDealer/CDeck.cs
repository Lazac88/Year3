using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeDealer
{
    public class CDeck
    {
        private const int SuitCount = 13;
        private const int TotalSuits = 4;
        private CCard[,] deck;

        public CDeck()
        //------------------------------------------------
        // CDeck()
        //
        // Precondition: None.
        // Postcondition: Initializes all the properties.
        //------------------------------------------------
        {
            deck = new CCard[TotalSuits, SuitCount];

            for (int i = 0; i < TotalSuits; i++)
                for (int j = 0; j < SuitCount; j++)
                    deck[i, j] = new CCard((SuitValue)i, (CardValue)j);
        }

        public void ShuffledHands(CHand[] hands)
        //------------------------------------------------
        // ShuffledHands(CHand[] hands)
        //
        // Precondition: hands must be an array of initialized CHand objects.
        // Postcondition: Gives each hand 13 random cards.
        //------------------------------------------------
        {
            bool[,] handsUsed = new bool[TotalSuits, SuitCount];
            Random rand = new Random();

            for(int i = 0; i < hands.Length; i++)
            {
                int cardCount = 0;

                while(cardCount < CHand.handSize)
                {
                    int nextCardNumber = rand.Next(SuitCount);
                    int nextCardSuit = rand.Next(TotalSuits);

                    if (handsUsed[nextCardSuit, nextCardNumber] == false)
                    {
                        hands[i].Hand[cardCount].Suit = (SuitValue)nextCardSuit;
                        hands[i].Hand[cardCount].Number = (CardValue)nextCardNumber;

                        handsUsed[nextCardSuit, nextCardNumber] = true;
                        cardCount++;
                    }
                }
            }
        }

        // get/sets
        public CCard[,] Deck
        {
            get{ return deck; }
            set{ deck = value; }
        }
    }
}
