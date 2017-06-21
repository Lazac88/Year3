using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeDealer
{
    public enum Scores : int
    {
        ACE = 4, KING = 3, QUEEN = 2, JACK = 1
    }

    public class CHand
    {
        public static int handSize = 13;
        CCard[] hand;

        public CHand()
        //------------------------------------------------
        // CHand()
        //
        // Precondition: None.
        // Postcondition: Initializes all the properties.
        //------------------------------------------------
        {
            hand = new CCard[handSize];

            for (int i = 0; i < hand.Length; i++)
                hand[i] = new CCard(0, 0); //initilize the the hand. starts of with what the enumerator has set to 0, 0.
        }

        public int TotalPoints()
        //------------------------------------------------
        // int TotalPoints()
        //
        // Precondition: None.
        // Postcondition: Returns the total high card points for this hand.
        //------------------------------------------------
        {
            int TotalScore = 0;

            for (int i = 0; i < hand.Length; i++)
            {
                switch (hand[i].Number) //ace, king, queen and jack are the only cards worth high card points.
                {
                    case CardValue.ACE: //ace is worth 4
                        TotalScore += 4;
                    break;
                    case CardValue.KING: //king is worth 3
                        TotalScore += 3;
                    break;
                    case CardValue.QUEEN: //queen is worth 2
                        TotalScore += 2;
                    break;
                    case CardValue.JACK: //jack is worth 1
                        TotalScore += 1;
                    break;
                }
            }

            return TotalScore;
        }

        // get/sets
        public CCard[] Hand
        {
            get{ return hand; }
            set{ hand = value; }
        }
    }
}
