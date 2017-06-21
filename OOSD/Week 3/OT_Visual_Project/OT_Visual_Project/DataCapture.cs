using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT_Visual_Project
{
    class DataCapture : IData
    {
        //My database class. Knows how to store and retrieve Stimulus information

        private List<Stimulus> patientData;

        public DataCapture()
        {
            patientData = new List<Stimulus>();
        }


        //Adds new entry to patientData
        public void addData(Point stimPoint, Boolean stimulus, Boolean click)
        {
            Stimulus newEntry = new Stimulus(stimPoint, stimulus, click);
            patientData.Add(newEntry);
        }

        //Resets database for new run through
        public void clearData()
        {
            patientData.Clear();
        }

        //Return list of entries when patient has clicked correctly for a stimulus
        public List<Stimulus> findStimulusCorrect()
        {
            List<Stimulus> stimulusCorrect = new List<Stimulus>();
            foreach(Stimulus s in patientData)
            {
                Boolean stim = s.getStim();
                Boolean click = s.getClick();
                if(stim && click)
                {
                    stimulusCorrect.Add(s);
                }
            }
            return stimulusCorrect;
        }

        //Return list of entries when patient hasn't click when a stimulus is shown
        public List<Stimulus> findStimulusFalse()
        {
            List<Stimulus> stimulusFalse = new List<Stimulus>();
            foreach (Stimulus s in patientData)
            {
                Boolean stim = s.getStim();
                Boolean click = s.getClick();
                if (stim && !click)
                {
                    stimulusFalse.Add(s);
                }
            }
            return stimulusFalse;
        }

        //Return list of entries when patient has clicked for no stimulus
        public List<Stimulus> findNoStimulusCorrect()
        {
            List<Stimulus> noStimulusCorrect = new List<Stimulus>();
            foreach (Stimulus s in patientData)
            {
                Boolean stim = s.getStim();
                Boolean click = s.getClick();
                if (!stim && click)
                {
                    noStimulusCorrect.Add(s);
                }
            }
            return noStimulusCorrect;
        }

        //Return list of entries when the patient hasn't clicked and no stimulus
        public List<Stimulus> findNoStimulusFalse()
        {
            List<Stimulus> noStimulusFalse = new List<Stimulus>();
            foreach (Stimulus s in patientData)
            {
                Boolean stim = s.getStim();
                Boolean click = s.getClick();
                if (!stim && !click)
                {
                    noStimulusFalse.Add(s);
                }
            }
            return noStimulusFalse;
        }

        //Returns all data collected
        public List<Stimulus> returnAllData()
        {
            return patientData;
        }
    }
}
