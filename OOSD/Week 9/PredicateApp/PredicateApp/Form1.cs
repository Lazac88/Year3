using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NumberManager numberManager;
        Random rand;
        Predicate<int> selectionPred;

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
            numberManager = new NumberManager(listBoxAll, listBoxSelection, rand);
        }

        private void btnRandoms_Click(object sender, EventArgs e)
        {
            numberManager.generateNumberList();
            numberManager.displayAllNumbers();
        }

        private void btnEvenNums_Click(object sender, EventArgs e)
        {
            //selectionPred = numberManager.findEvenNum;
            numberManager.displayFilteredNumbers(delegate(int i) { return (i % 2) == 0; });
        }

        private void btnSmallNums_Click(object sender, EventArgs e)
        {
            //selectionPred = numberManager.findLowNum;

            numberManager.displayFilteredNumbers(delegate(int i) { return i < 10; });
        }
    }
}
