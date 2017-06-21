using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BridgeDealer
{
    public class CDealer
    {
        private const int playerCount = 4;
        private CDeck cards;
        private CHand[] players;

        public CDealer()
        {
            cards = new CDeck();
            players = new CHand[playerCount]; //initialize the players array.

            for (int i = 0; i < playerCount; i++) //create a new CHand object for all the players in the players array.
                players[i] = new CHand();
        }

        public void Deal(ListBox lb)
        {
            cards.ShuffledHands(players); //shuffles all the players cards.

            lb.Items.Clear();

            for (int i = 0; i < players.Length; i++)
            {
                lb.Items.Add(((Player)(i)).ToString()); //adds the player position on the table (based on the enumerator)
                lb.Items.Add("");

                for (int j = 0; j < players[i].Hand.Length; j++)
                    lb.Items.Add(players[i].Hand[j].ToString()); //adds each of the players cards to the list box.

                lb.Items.Add("");
                lb.Items.Add("HCP: " + players[i].TotalPoints().ToString()); //outputs the players high card point score.
                lb.Items.Add("-----------");
            }
        }
    }
}
