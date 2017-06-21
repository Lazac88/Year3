using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT_Visual_Project
{
    class Stimulus
    {
        Point stimulusLocation;
        Boolean stim;
        Boolean click;

        public Stimulus(Point location, Boolean stim, Boolean click)
        {
            this.stimulusLocation = location;
            this.stim = stim;
            this.click = click;
        }

        public Point getStimulusLoc()
        {
            return stimulusLocation;
        }

        public Boolean getStim()
        {
            return stim;
        }

        public Boolean getClick()
        {
            return click;
        }

        public override String ToString()
        {
            //Turn Boolean into string
            String stimWord = "";
            String clickWord = "";
            if(stim)
            {
                stimWord = "true";
            }
            else
            {
                stimWord = "false";
            }
            if(click)
            {
                clickWord = "true";
            }
            else
            {
                clickWord = "false";
            }

            String ColNumber = "";
            String RowNumber = "";

            //Turn Point into string
            
                ColNumber = stimulusLocation.X.ToString();
                RowNumber = stimulusLocation.Y.ToString();

            return ColNumber + ", " + RowNumber + ", " + stimWord + ", " + clickWord;
        }
    }
}
