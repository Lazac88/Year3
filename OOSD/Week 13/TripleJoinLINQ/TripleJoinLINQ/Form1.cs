using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleJoinLINQ
{
    public partial class Form1 : Form
    {
        WorldDbDataContext worldDb;

        public Form1()
        {
            InitializeComponent();
            worldDb = new WorldDbDataContext();
        }

        private async void btnFindCities_Click(object sender, EventArgs e)
        {
            lBoxOutput.Items.Clear();
            string userInput = txtBoxInput.Text;

            //Using Task to run on seperate thread
            Task<List<OutputInformation>> findCityMatches = Task.Run(() => GetCityMatches(userInput));
            List<OutputInformation> cityMatches = await findCityMatches;


            //List<OutputInformation> cityMatches = GetCityMatches(userInput);
            if (cityMatches.Any())
            {
                foreach(OutputInformation o in cityMatches)
                {
                    lBoxOutput.Items.Add(o.ToString());
                }
            }
            else
            {
                lBoxOutput.Items.Add("No Cities Found By This Name");
            }
        }

        private List<OutputInformation> GetCityMatches(string cityName)
        {
            List<OutputInformation> cityMatches = new List<OutputInformation>();

            var query = from countries in worldDb.countries
                        join cities in worldDb.cities on countries.Code equals cities.CountryCode
                        join language in worldDb.countrylanguages on countries.Code equals language.CountryCode
                        where cities.Name == cityName
                        select new { countries.Name, language.Language };

            foreach (var info in query)
            {
                string country = info.Name;
                string language = info.Language;
                OutputInformation outInfo = new OutputInformation(cityName, country, language);
                cityMatches.Add(outInfo);
            }

            //Used to slow down search
            for(int i = 0; i < 100000; i++)
            {
                for(int j = 0; j < 10000; j++)
                {
                    int x = i * j;
                }
            }
            return cityMatches;
        }
    }
}
