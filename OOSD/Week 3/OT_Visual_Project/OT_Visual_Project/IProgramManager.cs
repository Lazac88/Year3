using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT_Visual_Project
{
    interface IProgramManager
    {
        void startStimulus();
        void runStimulus();
        Point calculateStimulusPosition();
        void registerClick();
        void writeResultsToCSV();
    }
}
