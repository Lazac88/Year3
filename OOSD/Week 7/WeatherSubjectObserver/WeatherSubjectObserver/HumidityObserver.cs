using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSubjectObserver
{
    public class HumidityObserver : BaseObserver
    {
        public HumidityObserver(WeatherSubject mySubject)
            : base(mySubject)
        {
            mySubject.AddObserver(this);
            readingType = "Humidity";
        }

        public override void Update(Weather newWeather)
        {
            currentReading = (decimal)newWeather.Humidity;
            CalculateAverage();
        }
    }
}
