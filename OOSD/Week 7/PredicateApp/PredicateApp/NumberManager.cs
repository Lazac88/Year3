using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateApp
{
    public class NumberManager
    {
        private const int NUMS_IN_LIST = 50;
        private const int MAX_NUMBER = 100;

        private List<int> numberList;
        private ListBox displayAll;
        private ListBox displaySelected;
        private Random rand;

        public NumberManager(ListBox displayAll, ListBox displaySelected, Random rand)
        {
            this.displayAll = displayAll;
            this.displaySelected = displaySelected;
            this.rand = rand;
            numberList = new List<int>();
        }

        public void generateNumberList()
        {
            numberList.Clear();
            for(int i = 0; i < NUMS_IN_LIST; i++)
            {
                int randNumber = rand.Next(MAX_NUMBER);
                numberList.Add(randNumber);
            }
        }

        public void displayAllNumbers()
        {
            displayAll.Items.Clear();
            foreach(int i in numberList)
            {
                displayAll.Items.Add(i);
            }
        }

        public void displayFilteredNumbers(Predicate<int> selectionPred)
        {
            displaySelected.Items.Clear();
            List<int> selectedNumbers = numberList.FindAll(selectionPred);
            foreach(int i in selectedNumbers)
            {
                displaySelected.Items.Add(i);
            }
        }

        public bool findEvenNum(int i)
        {
            bool isEven = ((i % 2) == 0);
            return isEven;
        }

        public bool findLowNum(int i)
        {
            bool isLow = (i < 10);
            return isLow;
        }
    }
}
