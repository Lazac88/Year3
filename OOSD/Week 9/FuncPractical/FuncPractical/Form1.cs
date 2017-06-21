using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncPractical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<City> myCities;
        //Func<List<City>, string, List<City>> SearchByCountry = (cityList, countryName) => cityList.Where(c => c.CountryName == countryName).ToList();
        Func<List<City>, string, List<City>> SearchByCountry = (cityList, countryName) => cityList.FindAll(c => c.CountryName == countryName);

        private void Form1_Load(object sender, EventArgs e)
        {
            myCities = new List<City>();
            myCities = FullCityList();
            Func<List<City>, string, List<City>> SearchByCountry = (cityList, countryName) => cityList.Where(c => c.CountryName == countryName).ToList();            
        }

        private List<City> FullCityList()
        {
            City city1 = new FuncPractical.City("Dunedin", "New Zealand", 80000);
            City city2 = new FuncPractical.City("Cairo", "Egypt", 1000000);
            City city3 = new FuncPractical.City("Wellington", "New Zealand", 100000);
            City city4 = new FuncPractical.City("Christchurch", "New Zealand", 120000);
            City city5 = new FuncPractical.City("Los Angelos", "United States", 2000000);
            List<City> myList = new List<City>();
            myList.Add(city1);
            myList.Add(city2);
            myList.Add(city3);
            myList.Add(city4);
            myList.Add(city5);
            return myList;
        }

        private void btnCountrySearch_Click(object sender, EventArgs e)
        {
            string searchKey = txtBoxCountryInput.Text;
            List<City> filteredCities = SearchByCountry(myCities, searchKey);

            listBoxCountry.Items.Clear();
            foreach (City c in filteredCities)
            {                
                listBoxCountry.Items.Add(c.CityName);
            }
        }

        private void btnIncreasePop_Click(object sender, EventArgs e)
        {
            myCities.ForEach(c => c.Population = c.Population *= 3);
            listBoxCountry.Items.Clear();
            myCities.ForEach(c => listBoxCountry.Items.Add(c.Population));
        }
    }

    public class City
    {
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }

        public City(string cityName, string countryName, int population)
        {
            CityName = cityName;
            CountryName = countryName;
            Population = population;
        }
    }
}
