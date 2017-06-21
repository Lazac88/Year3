using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class TCard
    {
        private int privateNumber;
        private int privateSuit;

        public int number
        {
            get
            {
                return privateNumber;
            }

            set
            {
                privateNumber = value;
            }
        }

        public int suit
        {
            get
            {
                return privateSuit;
            }

            set
            {
                privateSuit = value;
            }
        }

        public TCard (int number, int suit)
        {
            privateNumber = number;
            privateSuit = suit;
        }

        public override string ToString()
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

            ThisCard += ": ";

            switch (privateSuit)
            {
                case 0:
                    ThisCard += "Spades";
                    break;

                case 1:
                    ThisCard += "Clubs";
                    break;

                case 2:
                    ThisCard += "Diamonds";
                    break;

                case 3:
                    ThisCard += "Hearts";
                    break;
            }
            return ThisCard + "\r\n";
        }

        public int getSuit()
        {
            return privateSuit;
        }

        public int getNumber()
        {
            return privateNumber;
        }
    }
}
