using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherFinder2.Models;

namespace WeatherFinder2.Controllers
{
    //Weather API = OpenWeatherMap
    //API Key = 0df6799da7c1de61da825beb676d64ba
    //Example Query: api.openweathermap.org/data/2.5/weather?APPID=0df6799da7c1de61da825beb676d64ba&q=London


    public class WeatherController : Controller
    {
        //Get database
        private DataClasses1DataContext worldDB;

        //Get a web processor
        HttpProcessor httpProcessor;

        //

        public WeatherController()
        {
            worldDB = new DataClasses1DataContext();
            httpProcessor = new HttpProcessor();
        }

        // GET: Weather
        [HttpGet]
        public ActionResult Index()
        {
            List<SelectListItem> countryCodes = new List<SelectListItem>();

            var allCountryCodes = from c in worldDB.cities
                                  select c.CountryCode;

            var x = allCountryCodes.GroupBy(c => c).Select(g => g.First()).OrderBy(o => o);
            
            foreach(var countryCode in x)
            {
                countryCodes.Add(new SelectListItem { Text = countryCode, Value = countryCode });
            }
            CountryCodeViewModel ccvm = new CountryCodeViewModel();
            ccvm.CountryCodes = countryCodes;
            return View(ccvm);
        }

        [HttpPost]
        public ActionResult Index(string CODE)
        {
            CityViewModel largestCity = GetLargestCity(CODE);

            string url = MakeWeatherURL(largestCity.CityName);
            string returnJSON = httpProcessor.GetJSONStringFromURL(url);
            Debug.WriteLine(returnJSON);

            JObject baseObject = JObject.Parse(returnJSON);

            List<JObject> arrayOfJsonObjects = new List<JObject>();
            arrayOfJsonObjects = baseObject["weather"].Select(w => (JObject)w).ToList();

            string weather = (string)arrayOfJsonObjects[0]["main"];
            string description = (string)arrayOfJsonObjects[0]["description"];

            CityWeatherViewModel cityWeather = new CityWeatherViewModel(largestCity.CityName, weather, description, largestCity.Population);

            return View("WeatherResult", cityWeather);
        }

        public CityViewModel GetLargestCity(string countryCode)
        {
            var e = from c in worldDB.cities
                    where c.CountryCode == countryCode
                    select c;
            var maxcity = e.OrderByDescending(i => i.Population).First();

            CityViewModel cvm = new CityViewModel();
            cvm.CityName = maxcity.Name;
            cvm.Population = maxcity.Population;

            return cvm;
        }

        public string MakeWeatherURL(string cityName)
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?APPID=0df6799da7c1de61da825beb676d64ba&q=";
            url += cityName;
            return url;
        }
    }
}