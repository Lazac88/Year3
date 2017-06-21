using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubjectObserverDesign
{
    public abstract class BaseObserver
    {
        protected double currentRPM;
        protected double currentComputedValue;
        protected Label displayLabel;
        protected SubjectMonitorRPM mySubject;

        public BaseObserver(Label displayLabel, SubjectMonitorRPM myMonitor)
        {
            this.mySubject = myMonitor;
            this.displayLabel = displayLabel;
            currentRPM = 0;
            currentComputedValue = 0;

            mySubject.addObserver(this);
        }

        public abstract void Update(int currentRPM);

        public void DisplayData()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }
    }
}
