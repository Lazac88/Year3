using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OT_Visual_Project
{
    class AppManager : IProgramManager
    {
        private const int NO_DISPLAY_DEFAULT = 10;
        private const int TIME_BETWEEN_TICKS = 100;
        private const int RANDOM_GEN_MAX = 101; //For random generator max number generated will be 100

        private DataCapture dataCapture;
        private GraphicDisplay graphicDisplay;
        private ResultsWriter rw;

        private Boolean noDisplay;
        private int noDisplayChance { get; set; }

        private Point numberColumnRows;
        private Point stimulusLocation;
        private Point noDisplayPoint;

        Random rand;

        Boolean hasClicked;
        Boolean firstTick;

        public AppManager(Point widthHeight, Panel displayPanel)
        {
            noDisplay = true;
            dataCapture = new DataCapture();
            graphicDisplay = new GraphicDisplay(widthHeight, displayPanel);
            rw = new ResultsWriter();

            noDisplayChance = NO_DISPLAY_DEFAULT;
            rand = new Random();
            hasClicked = true;
            firstTick = true;

            noDisplayPoint = new Point(-1, -1);

            //Set rows & columns for screen size
            numberColumnRows = calculateColRows(widthHeight);
            stimulusLocation = calculateStimulusPosition();           
        }

        public void startStimulus()
        {
            //Clear the DataCapture class
            dataCapture.clearData();

            //Timer calls runStimulus()
        }

        public void runStimulus()
        {
            if(!firstTick)
            {
                checkForClick();
            }
            else
            {
                firstTick = false;
            }

            Thread.Sleep(TIME_BETWEEN_TICKS);
            hasClicked = false;

            //For each timer tick...

            //Clear Screen
            graphicDisplay.clearPanel();

            //Check for a noDispay
            noDisplay = setNoDisplay();

            //If noDisplay == false, find a random spot on the panel display for the square
            if(!noDisplay)
            {
                stimulusLocation = calculateStimulusPosition();
                graphicDisplay.drawStimulus(stimulusLocation);
            }

            //Listen for a click (or a keypress)
            //Store data depending on patients response. Need to store data even during a noDisplay event.
            //Change stimulus colour if patient clicks correctly
        }

        //finds a random position on the panel to print a stimulus
        public Point calculateStimulusPosition()
        {
            int squareRow = rand.Next((numberColumnRows.Y + 1));
            int squareColumn = rand.Next((numberColumnRows.X + 1));
            return new Point(squareColumn, squareRow);
        }

        //Calculates the total number of columns and rows for the screen size
        public Point calculateColRows(Point widthHeight)
        {
            int height = widthHeight.Y;
            int width = widthHeight.X;
            int numRows = height / 50;
            int numCols = width / 50;
            return new Point (numCols, numRows);
        }

        public Boolean setNoDisplay()  //Method to randomly determine a noDisplay chance
        {
            int displayChance = rand.Next(RANDOM_GEN_MAX);
            if(displayChance < noDisplayChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void registerClick()
        {
            if(!firstTick && !hasClicked) //Stops users clicking before the timer has started and clicking multiple times during a timer tick
            {
                hasClicked = true;

                if (!noDisplay)  //If stimulus is showing, change the colour
                {
                    graphicDisplay.changeStimulusColour(stimulusLocation);
                }

                Boolean x = !noDisplay;
                dataCapture.addData(stimulusLocation, x, true);

                //Test
                //foreach (Stimulus s in dataCapture.findAllStimulus())
                //{
                //    dataBox.Items.Add(s.ToString());
                //}
            }            
        }

        public void checkForClick()
        {
            if(!hasClicked && noDisplay)        //Stimulus not displayed and patient hasn't clicked.
            {
                dataCapture.addData(noDisplayPoint, false, false);
            }
            else if(!hasClicked && !noDisplay)  //Stimulus has displayed and patient hasn't clicked.
            {
                dataCapture.addData(stimulusLocation, true, false);
            }
        }

        public void writeResultsToCSV()     //writes results to the csv file
        {
            rw.writeToCSV(dataCapture.returnAllData());
        }

        public void displayCorrectClicks()
        {
            graphicDisplay.clearPanel();
            graphicDisplay.drawAllStimulus(dataCapture.findStimulusCorrect());
        }

        public void displayMissedClicks()
        {
            graphicDisplay.clearPanel();
            graphicDisplay.drawAllStimulus(dataCapture.findStimulusFalse());
        }
        
    }
}
