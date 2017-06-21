using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherSubjectObserver
{
    public class TempObserver : BaseObserver
    {

        public TempObserver(WeatherSubject mySubject)
            : base (mySubject)
        {
            mySubject.AddObserver(this);
            readingType = "Temperature";
        }

        public override void Update(Weather newWeather)
        {
            currentReading = (decimal)newWeather.Temp;
            CalculateAverage();
        }
    }
}
