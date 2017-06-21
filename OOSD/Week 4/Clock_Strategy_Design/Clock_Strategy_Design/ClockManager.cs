using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Strategy_Design
{
    class ClockManager
    {

        public IClock clockType { get; set; }
        Label digitalLabel;
        Boolean digitalOn;

        public ClockManager(Label digitalLabel)
        {
            clockType = new DigitalClock(digitalLabel);
            this.digitalLabel = digitalLabel;
            digitalOn = false;
        }

        public void runClock()
        {
            clockType.UpdateTimeDisplay();
            if(digitalOn)
            {
                digitalLabel.Text = clockType.UpdateTimeDisplay();
            }
            
        }

        public void hideClock()
        {
            clockType.HideClock();
        }

        public void showClock()
        {
            clockType.ShowClock();
        }

        public void startClock()
        {
            clockType.On();
            digitalOn = true;
        }

        public void stopClock()
        {
            clockType.Off();
            digitalOn = false;
        }
    }
}
