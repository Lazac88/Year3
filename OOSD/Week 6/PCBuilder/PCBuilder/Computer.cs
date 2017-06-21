using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public class Computer
    {
        protected ListBox displayBox;
        protected IComputerFactory computerFactory;

        public Computer(ListBox displayBox)
        {
            this.displayBox = displayBox;
        }

        public void displaySpecs()
        {
            Ram pcRam = computerFactory.getRam();
            CPU pcCPU = computerFactory.getCPU();
            GCard pcGCard = computerFactory.getGCard();
            Storage pcStorage = computerFactory.getStorage();

            //Calculate Total Price
            double total = pcRam.Price + pcCPU.Price + pcGCard.Price + pcStorage.Price;
            string totalString = Convert.ToString(total);

            //Throw information into list box
            displayBox.Items.Add("Price          Component");
            displayBox.Items.Add("________________________");
            displayBox.Items.Add(pcRam.ToString());
            displayBox.Items.Add(pcCPU.ToString());
            displayBox.Items.Add(pcGCard.ToString());
            displayBox.Items.Add(pcStorage.ToString());
            displayBox.Items.Add("________________________");
            displayBox.Items.Add("Total Price: " + totalString);
        }
    }
}
