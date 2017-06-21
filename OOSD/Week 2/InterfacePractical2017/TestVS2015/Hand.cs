using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicBridgeDealer2017
{
    public class Hand: IComparable<Hand>
    {
        public List<Card> CardsInHand { get; set; }
        public int TotalHCP
        {
            get; set;
        }

        public Hand()
        {
            CardsInHand = new List<Card>();
        }

        public void OrderHand()
        {
            for (int i = 0; i < CardsInHand.Count; i++)
            {
                Card maxCard = CardsInHand[i];
                int minPos = i;

                for (int j = i; j < CardsInHand.Count; j++)
                {
                    if (CardsInHand[j].Rank > maxCard.Rank)
                    {
                        maxCard = CardsInHand[j];
                        minPos = j;
                    }
                }
                Card tempCard = CardsInHand[minPos];
                CardsInHand[minPos] = CardsInHand[i];
                CardsInHand[i] = tempCard;
            }
        }

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);
        }

        public int ComputeHCP()
        {
            TotalHCP = 0;
            foreach (Card c in CardsInHand)
                TotalHCP += c.HCP;

            return 0;
        }

        public int CompareTo(Hand other)
        {
            return other.TotalHCP.CompareTo(this.TotalHCP);
        }
    }
}