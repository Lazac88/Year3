using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{

    public class CritterCatalogue
    {
        string inputFileName;
        private List<Critter> critterList;

        public CritterCatalogue(string inputFileName)
        {
            this.inputFileName = inputFileName;
            critterList = new List<Critter>();
            loadCritterList();
        }

        //=======================================================================
        private void loadCritterList()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(inputFileName);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Can't find the input file!");
            }

            if (sr != null)
            {
                String currentLine = "";
                String[] currentAnimal;


                while ((currentLine = sr.ReadLine()) != null)
                {
                    currentAnimal = currentLine.Split(',');

                    ESpecies currentSpecies = (ESpecies)System.Enum.Parse(typeof(ESpecies), currentAnimal[1]);
                    critterList.Add(new Critter(currentAnimal[0], currentSpecies));
                } // end for each line
            } // end if sr != null
        } // end loadCritterList

        //=======================================================================
        public void PrintAllCritters(ListBox displayBox)
        {
            displayBox.Items.Clear();
            foreach (Critter c in critterList)
            {
                displayBox.Items.Add(c.ToString());
            }
        }

        //=======================================================================
        // Returns a List<Critter> containing all Critters of species equal to the
        // passed in argument.
        //=======================================================================
        public List<Critter> CritterQuery(string speciesName)
        {
            List<Critter> selectedCritters = new List<Critter>();
            ESpecies currentSpecies = (ESpecies)System.Enum.Parse(typeof(ESpecies), speciesName);

            foreach (Critter c in critterList)
            {
                if (c.Species == currentSpecies)
                    selectedCritters.Add(c);
            }
            return selectedCritters;
        }

    }
}
