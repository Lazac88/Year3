using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT_Visual_Project
{
    class Ball
    {
        DateTime dt;
        String timeStamp;       //Generates own timestamp when created
        Point ballLocation;
        DataEvent dataEvent;


        public Ball(Point ballLocation, DataEvent dataEvent)
        {
            dt = DateTime.Now;
            timeStamp = dt.ToString("dd-MM-yyyy-HHmm");
            this.ballLocation = ballLocation;
            this.dataEvent = dataEvent;
        }

        public String getTimeStamp()
        {
            return timeStamp;
        }

        public Point getBallLocation()
        {
            return ballLocation;
        }

        public DataEvent getDataEvent()
        {
            return dataEvent;
        }

        //ToString prints out in csv format
        public override String ToString()
        {
            String csvOutput = "";
            String xLoc = ballLocation.X.ToString();
            String yLoc = ballLocation.Y.ToString();
            csvOutput = timeStamp + ", " + xLoc + ", " + yLoc + ", " + dataEvent;
            return csvOutput;
        }
    }
}
