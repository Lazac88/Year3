using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectObserverDesign
{
    public class SubjectMonitorRPM
    {
        private List<BaseObserver> myList;
        public int cycleRPM { get; set; }

        public SubjectMonitorRPM()
        {
            myList = new List<BaseObserver>();
        }

        public void addObserver(BaseObserver observer)
        {
            myList.Add(observer);
        }

        public void removeObserver(BaseObserver observer)
        {
            myList.Remove(observer);
        }

        public void alertObservers()
        {
            foreach(BaseObserver o in myList)
            {
                o.Update(cycleRPM);
            }
        }
    }
}
