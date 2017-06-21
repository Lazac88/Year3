using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherFinder2.Models
{
    public class CityWeatherViewModel
    {
        public string CityName { get; set; }
        public string Weather { get; set; }
        public string Description { get; set; }
        public int Population { get; set; }

        public CityWeatherViewModel(string cityname, string weather, string description, int population)
        {
            this.CityName = cityname;
            this.Weather = weather;
            this.Description = description;
            this.Population = population;
        }
    }
}