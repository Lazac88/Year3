using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeDealer
{
    public enum SuitValue : int
    {
        SPADES, HEARTS, DIAMONDS, CLUBS
    }

    public enum CardValue : int
    {
        ACE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING
    }

    public class CCard
    {
        private SuitValue suit;
        private CardValue number;

        public CCard(SuitValue suit, CardValue number)
        //------------------------------------------------
        // CCard(SuitValue suit, CardValue number)
        //
        // Precondition: suit must be a value in the SuitValue enumerator. number must be a value in the CardValue enumerator.
        // Postcondition: Sets up the default properties.
        //------------------------------------------------
        {
            this.suit = suit;
            this.number = number;
        }

        public override string ToString()
        //------------------------------------------------
        // string ToString()
        //
        // Precondition: None.
        // Postcondition: Returns the suit and card number of the enumerators.
        //------------------------------------------------
        {
            return (number.ToString() + " of " + suit.ToString());
        }

        public SuitValue Suit
        {
            get{ return suit; }
            set{ suit = value; }
        }

        public CardValue Number
        {
            get{ return number; }
            set{ number = value; }
        }
    }
}
