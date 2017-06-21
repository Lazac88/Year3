using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmEvents
{
    public abstract class FireAlarmObserverBase
    {
        protected FireAlarmSubject subject;

        public FireAlarmObserverBase(FireAlarmSubject subject)
        {
            this.subject = subject;

            FireAlarmSubject.FireEventHandler handler = new FireAlarmSubject.FireEventHandler(FireAlarmHandlerMethod);

            subject.FireEvent += handler;
        }

        public abstract void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe);
    }
}
