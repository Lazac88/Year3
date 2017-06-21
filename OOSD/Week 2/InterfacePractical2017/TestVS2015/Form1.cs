using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicBridgeDealer2017
{
    public enum Player : int
    {
        NORTH, EAST, SOUTH, WEST
    }

    public partial class Form1 : Form
    {

        Deck mainDeck;

        public Form1()
        {
            InitializeComponent();
            mainDeck = new Deck();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();

            List<Hand> deal = mainDeck.Deal(4, 13);
            deal.Sort();

            PlayingCardPrinter playingCardPrinter = new PlayingCardPrinter();

            playingCardPrinter.PrintDeal(lstDisplay, deal);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
