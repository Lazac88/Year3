using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSubjectObserver
{
    public abstract class BaseObserver
    {
        protected WeatherSubject mySubject;
        protected decimal currentReading;
        public decimal CurrentReading
        {
            get { return currentReading; }
        }
        protected decimal currentAverage;
        public decimal CurrentAverage
        {
            get { return currentAverage; }
        }
        protected int readingCount;
        protected string readingType;

        public BaseObserver(WeatherSubject mySubject)
        {
            this.mySubject = mySubject;
            currentReading = 0;
            currentAverage = 0;
            readingCount = 0;
        }

        public abstract void Update(Weather newWeather);

        public void CalculateAverage()
        {
            decimal tempValue = currentAverage * readingCount;
            readingCount++;
            tempValue += currentReading;
            currentAverage = (tempValue / readingCount);
            currentAverage = Math.Round(currentAverage, 2);
        }

        public override string ToString()
        {
            string displayInfo = readingType;
            return displayInfo;
        }
    }
}
