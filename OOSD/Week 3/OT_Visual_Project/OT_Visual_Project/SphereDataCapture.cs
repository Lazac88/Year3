using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OT_Visual_Project
{
    class SphereDataCapture
    {
        private List<Ball> ballData;

        public SphereDataCapture()
        {
            ballData = new List<Ball>();
        }

        //Adds a point to the list. Data event is an enum that captures if the user has clicked or the stimulus has changed
        public void addData(Point ballPoint, DataEvent dataEvent)
        {
            Ball newBall = new Ball(ballPoint, dataEvent);
            ballData.Add(newBall);
        }

        public void clearData()
        {
            ballData.Clear();
        }

        public List<Ball> returnAllData()
        {
            return ballData;
        }
    }
}
