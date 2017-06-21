using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT_Visual_Project
{
    class ResultsWriter
    {

        //Simple class to allow writing to csv file
        //Made it a class on its own in case different output is ever required

        public ResultsWriter()
        {

        }

        //Writes results for the stimulus
        public void writeToCSV(List<Stimulus> results)
        {
            DateTime dt = DateTime.Now;
            String timeStamp = dt.ToString("dd-MM-yyyy-HHmm");
            String fileName = "results" + timeStamp + ".csv";

            StreamWriter sw = new StreamWriter(fileName);

            
            foreach (Stimulus s in results)
            {
                 sw.WriteLine(s.ToString());
            }
            sw.Close();            
        }

        //Writes results for the ball tracking
        public void writeBallDataToCSV(List<Ball> results)
        {
            DateTime dt = DateTime.Now;
            String timeStamp = dt.ToString("dd-MM-yyyy-HHmmss");
            String fileName = "ballResults" + timeStamp + ".csv";

            StreamWriter sw = new StreamWriter(fileName);


            foreach (Ball b in results)
            {
                sw.WriteLine(b.ToString());
            }
            sw.Close();          
        }
    }
}
