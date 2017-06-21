using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_Strategy_Design
{
    class DisplayMany : IPrint
    {
        List<Critter> myList;
        ListBox listBoxDisplay;

        public DisplayMany(ListBox listBoxDisplay)
        {
            this.myList = new List<Critter>();
            this.listBoxDisplay = listBoxDisplay;
        }
        public void DisplayAnimals(List<Critter> myList)
        {
            throw new NotImplementedException();
        }
    }
}
