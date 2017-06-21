using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubjectObserverDesign
{
    public class CalorieObserver : BaseObserver
    {
        private const int CALORIE_MULTIPLIER = 5;

        public CalorieObserver(Label displayLabel, SubjectMonitorRPM myMonitor)
            : base(displayLabel, myMonitor)
        {

        }
        public override void Update(int currentRPM)
        {
            int myCalories = currentRPM * CALORIE_MULTIPLIER;
            currentComputedValue = myCalories;
            DisplayData();
        }
    }
}
