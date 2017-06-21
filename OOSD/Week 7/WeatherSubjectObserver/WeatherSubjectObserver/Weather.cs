using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSubjectObserver
{
    public class Weather
    {
        private double temp;
        public double Temp
        {
            get { return temp; }
        }

        private double humidity;
        public double Humidity
        {
            get { return humidity; }
        }
        private double pressure;
        public double Pressure
        {
            get { return pressure; }
        }

        public Weather(double temp, double humidity, double pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
        }
    }
}
