using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    class GameManager
    {
        const int handNumber = 13;
        const int deckNumber = 52;
        const int numberOfHands = 4;

        ListBox listBox;

        List<Hand> myHands = new List<Hand>();

        Deck deck;

        Card[] shuffledDeck;

        public GameManager(ListBox listBox)
        {
            this.listBox = listBox;
            deck = new Bridge.Deck();
            createDeck();
            createHands();
            

            shuffledDeck = new Card[deckNumber];
        }

        public void createDeck()
        {
            deck.createDeck();            
        }

        public void shuffleDeck()
        {
            deck.shuffleDeck();
            //Grab new shuffled deck
            shuffledDeck = deck.getMyDeck();
        }

        public void createHands()
        {
            //Creating the 4 hands
            Hand handN = new Bridge.Hand(listBox, "NORTH");
            myHands.Add(handN);
            Hand handS = new Bridge.Hand(listBox, "EAST");
            myHands.Add(handS);
            Hand handE = new Bridge.Hand(listBox, "SOUTH");
            myHands.Add(handE);
            Hand handW = new Bridge.Hand(listBox, "WEST");
            myHands.Add(handW);            
        }

        public void fillHands()
        {
            //fills each hand with 13 cards
            shuffleDeck();
            for(int i = 0; i < numberOfHands; i++)
            {
                Card[] newHand = new Card[handNumber];
                for(int j = 0; j < handNumber; j++)
                {
                    //Calculating the count without an external count
                    int deckCount = (handNumber * i) + j;
                    newHand[j] = shuffledDeck[deckCount];
                }
                myHands[i].setHand(newHand);
            }
        }

        public void displayHands()
        {
            //clears list box and prints new hands
            listBox.Items.Clear();
            foreach(Hand currentHand in myHands)
            {
                currentHand.orderHand();
                currentHand.displayHand();             
                listBox.Items.Add("");
                listBox.Items.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                listBox.Items.Add("");
            }
        }
    }
}
