using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Card
    {
        private int value;
        private Suit suit;

        public Card(Suit suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public Suit getSuit()
        {
            return suit;
        }

        public int getValue()
        {
            return value;
        }

        public override string ToString()
        {
            //Not used but retained for future use
            return value + " of " + suit;
        }
    }
}
