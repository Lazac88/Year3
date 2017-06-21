using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBarEvents
{
    public class ProgressBarSubject
    {
        //No need for a custom EventArgs class. We do not need to pass data
        public delegate void EventHandler(object progressSubject, EventArgs e);

        //Create an instance of the ButtonEventHandler
        public event EventHandler ButtonEvent;

        public event EventHandler ClearEvent;

        public void OnButtonClick()
        {
            //Create an EventArgs instance
            EventArgs e = new EventArgs();

            //Check that some observers have subscribed to this event
            if(ButtonEvent != null)
            {
                ButtonEvent(this, e);       //Do event
            }
        }

        public void OnClearEvent()
        {
            EventArgs e = new EventArgs();

            if(ClearEvent != null)
            {
                ClearEvent(this, e);
            }
        }
    }
}
