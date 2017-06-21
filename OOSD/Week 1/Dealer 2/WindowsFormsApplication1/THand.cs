using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class THand
    {
        private TCard[] cards;
        private int privatePoints;
        private int numCards;

        public int points
        {
            get
            {
                return privatePoints;
            }

            set
            {
                privatePoints = value;
            }
        }

        public THand()
        {
            cards = new TCard[13];
        }

        public THand(TCard[] cardArray)
        {
            cards = new TCard[13];

            for (int i = 0; i < 13; i++)
            {
                cards[i] = cardArray[i];
            }
        }

        public void addCard(TCard newCard)
        {
            cards[numCards++] = newCard;
        }

        public int calcPoints()
        {
            privatePoints = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                switch (cards[i].number)
                {
                    case 14:
                        privatePoints += 4;
                        break;

                    case 11:
                        privatePoints += 1;
                        break;

                    case 12:
                        privatePoints += 2;
                        break;

                    case 13:
                        privatePoints += 3;
                        break;
                }
            }

            return privatePoints;
        }

        public void sortHand()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                TCard minCard = cards[i];
                int minPos = i;
                for (int j = i; j < cards.Length; j++)
                {
                    if (cards[j].suit < minCard.suit)
                    {
                        minCard = cards[j];
                        minPos = j;
                    }
                    else if (cards[j].suit == minCard.suit)
                    {
                        if (cards[j].number < minCard.number)
                        {
                            minCard = cards[j];
                            minPos = j;
                        }
                    }
                }
                TCard tempCard = cards[minPos];
                cards[minPos] = cards[i];
                cards[i] = tempCard;
            }
        }

        public override string ToString()
        {
            String myHand = "";
            for (int i = 0; i < 13; i++)
            {
                myHand += cards[i].ToString();
            }

            return myHand + "\r\n";
        }

        public String getCards(int suitRequested)
        {
            String cardsString = "";
            foreach(TCard i in cards)
            {
                if (i.getSuit() == suitRequested)
                {
                    int privateNumber = i.getNumber();
                    cardsString += getCardNumber(privateNumber);
                    cardsString += " ";
                }
            }
            return cardsString;
        }

        public String getCardNumber(int privateNumber)
        {
            String ThisCard = "";
            switch (privateNumber)
            {
                case 14:
                    ThisCard += "A";
                    break;

                case 13:
                    ThisCard += "K";
                    break;

                case 12:
                    ThisCard += "Q";
                    break;

                case 11:
                    ThisCard += "J";
                    break;
                case 10:
                    ThisCard += "T";
                    break;

                default:
                    ThisCard += privateNumber;
                    break;
            }
            return ThisCard;
        }
    }
}
