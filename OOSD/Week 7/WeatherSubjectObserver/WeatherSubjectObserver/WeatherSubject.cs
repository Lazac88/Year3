using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSubjectObserver
{
    public class WeatherSubject
    {
        private List<BaseObserver> myObservers;
        private Weather updatedWeather;
        public Weather UpdatedWeather
        {
            set { updatedWeather = value; }
        }

        public WeatherSubject()
        {
            myObservers = new List<BaseObserver>();
        }

        public void AddObserver(BaseObserver newObserver)
        {
            myObservers.Add(newObserver);
        }

        public void RemoveObserver(BaseObserver delObserver)
        {
            myObservers.Remove(delObserver);
        }

        public void AlertObservers()
        {
            foreach (BaseObserver o in myObservers)
            {
                o.Update(updatedWeather);
            }
        }
    }
}
