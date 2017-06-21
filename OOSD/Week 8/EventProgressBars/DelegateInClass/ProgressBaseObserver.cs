using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBarEvents
{
    public abstract class ProgressBaseObserver
    {
        protected ProgressBarSubject subject;

        public ProgressBaseObserver(ProgressBarSubject subject)
        {
            this.subject = subject;
            
            //Progress event
            ProgressBarSubject.EventHandler handler = new ProgressBarSubject.EventHandler(ProgressBarHandlerMethod);

            subject.ButtonEvent += handler;

            //Clear event
            ProgressBarSubject.EventHandler clearHandler = new ProgressBarSubject.EventHandler(ClearHandlerMethod);
            subject.ClearEvent += clearHandler;
        }

        public abstract void ProgressBarHandlerMethod(object progressSubject, EventArgs e);

        public abstract void ClearHandlerMethod(object progressSubject, EventArgs e);
    }
}
