using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Deck
    {
        const int deckNumber = 52;
        Card[] myDeck;
        Random rand;

        public Deck()
        {
            rand = new Random();
            myDeck = new Card[deckNumber];
        }

        public void createDeck()
        {
            //creates a new ordered deck
            int count = 0;
            Suit suit = new Suit();

            for(int i = 0; i < 4; i++)
            {
                for(int j = 2; j < 15; j++)
                {
                    switch(i)
                    {
                        case 0:
                            suit = Suit.Clubs;
                            break;
                        case 1:
                            suit = Suit.Spades;
                            break;
                        case 2:
                            suit = Suit.Diamonds;
                            break;
                        case 3:
                            suit = Suit.Hearts;
                            break;
                    }
                    myDeck[count] = new Card(suit, j);
                    count++;
                }
            }
        }

        public void shuffleDeck()
        {
            //Starts from first position in deck, picks a random spot within the deck, and swaps them
            //work way through each spot of array, so some cards could be shuffled more than once
            for(int i = 0; i < myDeck.Length; i++)
            {
                int j = rand.Next(deckNumber);
                Card temp = myDeck[i];
                myDeck[i] = myDeck[j];
                myDeck[j] = temp;
            }
        }

        public Card[] getMyDeck()
        {
            //returns current deck
            return myDeck;
        }
    }
}
