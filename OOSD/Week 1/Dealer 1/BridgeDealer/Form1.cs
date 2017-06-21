using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BridgeDealer
{
    public enum Player : int
    {
        NORTH, EAST, SOUTH, WEST
    }

    public partial class Form1 : Form
    {
        CDealer dealer;

        public Form1()
        {
            InitializeComponent();
            dealer = new CDealer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dealer.Deal(listBox1);
        }
    }
}
