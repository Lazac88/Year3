using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Strategy_Design
{
    class AnalogueClock : IClock
    {
        AnalogClockControl.AnalogClock analogueClock;
        public AnalogueClock(AnalogClockControl.AnalogClock analogueClock)
        {
            this.analogueClock = analogueClock;
        }

        public void HideClock()
        {
            analogueClock.Visible = false;
        }

        public void Off()
        {
            analogueClock.Stop();
        }

        public void On()
        {
            analogueClock.Start();
        }

        public void ShowClock()
        {
            analogueClock.Visible = true;
        }

        public String UpdateTimeDisplay()
        {
            //This method is not required
            return "";
        }
    }
}
