using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    class Hand
    {
        const int handNumber = 13;
        Card[] myHand;
        ListBox listBox;
        string handName;

        public Hand(ListBox listBox, string handName)
        {
            myHand = new Card[handNumber];
            this.listBox = listBox;
            this.handName = handName;
        }

        public void setHand(Card[] newHand)
        {
            //accepts 13 new cards from the game manager (dealer)
            myHand = newHand;
        }

        public Card[] getHand()
        {
            return myHand;
        }

        public void orderHand()
        {
            //works way along array, placing the highest card in the first potition
            //orders hand based on suit (enum number)
            //if suit is the same it checks if the card value is higher or lower
            for (int i = 0; i < myHand.Length; i++)
            {
                Card maxCard = myHand[i];
                int minPos = i;
                for (int j = i; j < myHand.Length; j++)
                {
                    if (myHand[j].getSuit() < maxCard.getSuit())
                    {
                        maxCard = myHand[j];
                        minPos = j;
                    }
                    else if (myHand[j].getSuit() == maxCard.getSuit())
                    {
                        if (myHand[j].getValue() > maxCard.getValue())
                        {
                            maxCard = myHand[j];
                            minPos = j;
                        }
                    }
                }
                Card tempCard = myHand[minPos];
                myHand[minPos] = myHand[i];
                myHand[i] = tempCard;
            }
        }

        public int getHCP()
        {

            //checks each card. Adds correspoding points from high card to HPC
            int HCP = 0;
            foreach (Card cards in myHand)
            {
                int cardValue = cards.getValue();

                switch (cardValue)
                {
                    case 11:
                        HCP += 1;
                        break;
                    case 12:
                        HCP += 2;
                        break;
                    case 13:
                        HCP += 3;
                        break;
                    case 14:
                        HCP += 4;
                        break;
                }
            }
            return HCP;
        }

        public void displayHand()
        {
            //creates a string with the correct specifications for the display for each suit
            string Spades = "S: ";
            string Hearts = "H: ";
            string Diamonds = "D: ";
            string Clubs = "C: ";            

            foreach (Card cards in myHand)
            {
                int cardValue = cards.getValue();
                string valueName;
                
                switch(cardValue)
                {
                    case 10:
                        valueName = "T";
                        break;
                    case 11:
                        valueName = "J";
                        break;
                    case 12:
                        valueName = "Q";
                        break;
                    case 13:
                        valueName = "K";
                        break;
                    case 14:
                        valueName = "A";
                        break;
                    default:
                        valueName = cardValue.ToString();
                        break;
                }
                
                Suit currentSuit = cards.getSuit();
                switch(currentSuit)
                {
                    case Suit.Spades:
                        Spades += valueName + " ";
                        break;
                    case Suit.Hearts:
                        Hearts += valueName + " ";
                        break;
                    case Suit.Diamonds:
                        Diamonds += valueName + " ";
                        break;
                    case Suit.Clubs:
                        Clubs += valueName + " ";
                        break;
                }
            }

            //adds each string to the listBox
            listBox.Items.Add(handName);
            listBox.Items.Add(Spades);
            listBox.Items.Add(Hearts);
            listBox.Items.Add(Diamonds);
            listBox.Items.Add(Clubs);
            //adds HCP to the listBox
            int HCP = getHCP();
            listBox.Items.Add("High Card Points: " + HCP);
        }
    }
}
