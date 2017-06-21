using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSubjectObserver
{
    public class PressureObserver : BaseObserver
    {
        public PressureObserver(WeatherSubject mySubject)
            : base(mySubject)
        {
            mySubject.AddObserver(this);
            readingType = "Pressure";
        }

        public override void Update(Weather newWeather)
        {
            currentReading = (decimal)newWeather.Pressure;
            CalculateAverage();
        }

        public string GetForecast()
        {
            if(currentReading > 950)
            {
                return "Clear skys ahead";
            }
            else
            {
                return "Looks like rain";
            }
        }
    }
}
