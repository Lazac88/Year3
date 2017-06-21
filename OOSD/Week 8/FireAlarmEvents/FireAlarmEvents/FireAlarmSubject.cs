using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmEvents
{
    
    public class FireAlarmSubject
    {
        //Create custom delegate. Must be void return type, and have object and EventArgs (or decendent) as parameters
        public delegate void FireEventHandler(object fireSubject, FireAlarmEventArgs fe);

        //Create an instance of the fire event delegate
        public event FireEventHandler FireEvent;

        public void OnFireEvent(EFireCategory fCat)
        {
            //Create an instance of our custom EventArgs class and pass it an enum
            FireAlarmEventArgs fe = new FireAlarmEventArgs(fCat);

            if(FireEvent != null)
            {
                FireEvent(this, fe);
            }
        }
    }    
}
