using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubjectObserverDesign
{
    public class RPMObserver : BaseObserver
    {
        public RPMObserver(Label displayLabel, SubjectMonitorRPM myMonitor)
            : base(displayLabel, myMonitor)
        {

        }

        public override void Update(int currentRPM)
        {
            this.currentComputedValue = (double)currentRPM;
            DisplayData();
        }
    }
}
