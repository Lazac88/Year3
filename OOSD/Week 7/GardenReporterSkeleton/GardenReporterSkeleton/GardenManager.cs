using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporterSkeleton
{
    public delegate string ReportProcessor(Garden myGarden);

    public class GardenManager
    {
        List<Garden> allGardens;
        ListBox displayArea;

        public GardenManager(ListBox displayArea)
        {
            allGardens = new List<Garden>();
            this.displayArea = displayArea;
        }

        public void ProcessGardens(ReportProcessor myReportProcessor)
        {
            displayArea.Items.Clear();
            foreach(Garden g in allGardens)
            {
                displayArea.Items.Add(myReportProcessor(g));
            }
        }

        public void AddGarden(Garden newGarden)
        {
            allGardens.Add(newGarden);
        }

        public void RemoveGarden(Garden oldGarden)
        {
            allGardens.Remove(oldGarden);
        }

        public string DisplayArea(Garden myGarden)
        {
            return myGarden.GetArea() + " m2";
        }

        public string DisplayAccounts(Garden myGarden)
        {
            return "$" + myGarden.GetAccountBalance();
        }
    }
}
