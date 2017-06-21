using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherSubjectObserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WeatherSubject mySubject;
        PressureObserver pressureObserver;
        TempObserver tempObserver;
        HumidityObserver humidityObserver;

        private void Form1_Load(object sender, EventArgs e)
        {
            mySubject = new WeatherSubject();
            tempObserver = new TempObserver(mySubject);
            humidityObserver = new HumidityObserver(mySubject);
            pressureObserver = new PressureObserver(mySubject);
        }

        private void btnUpdateWeather_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(txtBoxTemp.Text);
            double humid = Convert.ToDouble(txtBoxHumid.Text);
            double pressure = Convert.ToDouble(txtBoxPressure.Text);
            Weather myWeather = new Weather(temp, humid, pressure);
            mySubject.UpdatedWeather = myWeather;
            mySubject.AlertObservers();
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            //Update today weather listbox
            string todayTemp = tempObserver.ToString() + ":     " + Convert.ToString(tempObserver.CurrentReading);
            string todayHumid = humidityObserver.ToString() + ":     " + Convert.ToString(humidityObserver.CurrentReading);
            string todayPressure = pressureObserver.ToString() + ":     " + Convert.ToString(pressureObserver.CurrentReading);

            listBoxToday.Items.Clear();
            listBoxToday.Items.Add(todayTemp);
            listBoxToday.Items.Add(todayHumid);
            listBoxToday.Items.Add(todayPressure);

            //Update average listbox
            string tempAverage = tempObserver.ToString() + ":     " + Convert.ToString(tempObserver.CurrentAverage);
            string humidAverage = humidityObserver.ToString() + ":     " + Convert.ToString(humidityObserver.CurrentAverage);
            string pressureAverage = pressureObserver.ToString() + ":     " + Convert.ToString(pressureObserver.CurrentAverage);

            listBoxAverage.Items.Clear();
            listBoxAverage.Items.Add(tempAverage);
            listBoxAverage.Items.Add(humidAverage);
            listBoxAverage.Items.Add(pressureAverage);

            //Update forecast
            listBoxForecast.Items.Clear();
            listBoxForecast.Items.Add(pressureObserver.GetForecast());
        }
    }
}
