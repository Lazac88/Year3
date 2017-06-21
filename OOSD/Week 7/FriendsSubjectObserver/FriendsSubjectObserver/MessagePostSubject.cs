using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsSubjectObserver
{
    public class MessagePostSubject
    {
        private List<BaseObserver> myObservers;

        public MessagePostSubject()
        {
            myObservers = new List<BaseObserver>();
        }

        public void AddObserver(BaseObserver o)
        {
            myObservers.Add(o);
        }

        public void RemoveObservers(BaseObserver o)
        {
            myObservers.Remove(o);
        }

        public void AlertObservers(string newPost)
        {
            foreach(BaseObserver o in myObservers)
            {
                o.Update(newPost);
            }
        }
    }    
}
