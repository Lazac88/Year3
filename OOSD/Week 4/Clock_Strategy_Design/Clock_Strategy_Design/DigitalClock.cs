using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Strategy_Design
{
    class DigitalClock : IClock
    {
        Label timeDisplayLabel;
        public DigitalClock(Label digitalLabel)
        {
            this.timeDisplayLabel = digitalLabel;
        }

        public void HideClock()
        {
            timeDisplayLabel.Visible = false;
        }

        public void Off()
        {
            //Not needed
        }

        public void On()
        {
            //Not needed
        }

        public void ShowClock()
        {
            timeDisplayLabel.Visible = true;
        }

        public String UpdateTimeDisplay()
        {
            DateTime dt = DateTime.Now;
            String currentTime = dt.ToString("hh:mm:ss");
            return currentTime;
        }
    }
}
