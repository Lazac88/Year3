using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubjectObserverDesign
{
    public class DistanceObserver : BaseObserver
    {
        private const int HOUR = 60;
        private const int WHEEL_CIRCUM = 205;
        private const int METER = 100;
        private const int KILOMETER = 1000;
        public DistanceObserver(Label displayLabel, SubjectMonitorRPM myMonitor)
            : base(displayLabel, myMonitor)
        {

        }

        public override void Update(int currentRPM)
        {
            currentComputedValue = calculateDistancePerHour(currentRPM);
            DisplayData();
        }

        public double calculateDistancePerHour(int RPM)
        {
            double RPHour = RPM * HOUR;
            double cmPerHour = RPHour * WHEEL_CIRCUM;
            double mPerHour = cmPerHour / METER;
            double kmPerHour = mPerHour / KILOMETER;
            return kmPerHour;
        }
    }
}
