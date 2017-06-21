using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSubjectObserver
{
    public interface IWeatherObserver
    {
        void Update(Weather myWeather);
    }
}
