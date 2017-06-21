using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Strategy_Design
{
    interface IClock
    {
        void On();
        void Off();
        String UpdateTimeDisplay();
        void ShowClock();
        void HideClock();
    }
}
