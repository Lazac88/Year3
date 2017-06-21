using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OT_Visual_Project
{
    class SphereManager : IProgramManager
    {
        private const int COLOUR_CHANGE_CHANCE = 1;    //Chance sphere will change colour
        private const int DIRECTION_CHANGE_CHANCE = 1; //Chance the ball will change direction
        private const int RANDOM_GEN_MAX = 101; //For random generator max number generated will be 100
        private const int VELOCITY_DIRECTIONS = 3; //Zero based so add 1

        private const int SPHERE_SPEED = 1;
        private const int SPHERE_SIZE = 50;

        private SphereDataCapture dataCapture;
        private GraphicDisplaySphere graphicDisplay;
        private ResultsWriter rw;
        
        //Sphere information
        private Point sphereLocation;
        private Point sphereVelocity;

        private Point widthHeight;

        Random rand;
        
        public SphereManager(Point widthHeight, Panel displayPanel)
        {
            this.widthHeight = widthHeight;
            dataCapture = new SphereDataCapture();
            graphicDisplay = new GraphicDisplaySphere(displayPanel, widthHeight);
            rw = new ResultsWriter();

            rand = new Random();

            //Set sphere start position
            sphereLocation = sphereStartPosition();
            //Set sphere start direction
            sphereVelocity = new Point(1, 1);
        }
        
        public void runStimulus()
        {
            //hasClicked = false;
            //Clear panel
            graphicDisplay.clearPanel();

            //calculate change colour chance
            if(changeChance(COLOUR_CHANGE_CHANCE))
            {
                graphicDisplay.changeStimulusColour();
                
                //Create a datapoint
                dataCapture.addData(sphereLocation, DataEvent.StimChange);
            }
            //calculate change direction chance
            if(changeChance(DIRECTION_CHANGE_CHANCE))
            {
                changeSphereDirection();
            }

            //move sphere
            sphereLocation = calculateStimulusPosition();
            graphicDisplay.drawStimulus(sphereLocation);
            

            //Check for collision and correct velocity if it has hit a wall
            fixWallCollsion();

        }

        public void startStimulus()
        {
            dataCapture.clearData();
        }

        public Point sphereStartPosition()
        {
            int x = widthHeight.X / 2;      
            int y = widthHeight.Y / 2;      
            return new Point(x, y);
        }

        public Point calculateStimulusPosition()        //Method to move sphere
        {
            int currX = sphereLocation.X;
            int currY = sphereLocation.Y;

            int newX = currX + (SPHERE_SPEED * sphereVelocity.X);
            int newY = currY + (SPHERE_SPEED * sphereVelocity.Y);

            return new Point(newX, newY);
        }

        public void registerClick()
        {
            dataCapture.addData(sphereLocation, DataEvent.User);
        }        

        public void writeResultsToCSV()
        {
            rw.writeBallDataToCSV(dataCapture.returnAllData());
        }

        public Boolean changeChance(int chance)     //Simple method that takes in a chance (out of 100) and returns if the random gen hit that chance or not
        {
            int randomNumber = rand.Next(RANDOM_GEN_MAX);
            if(randomNumber < chance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void changeSphereDirection()
        {
            Boolean ballStopped = true;
            int randChance;
            while(ballStopped)      //Makes sure the ball doesn't have a X and Y velocity of 0
            {
                randChance = rand.Next(VELOCITY_DIRECTIONS);
                if (randChance == 0)
                {
                    sphereVelocity.Y = -1;
                }
                else if (randChance == 1)
                {
                    sphereVelocity.Y = 1;
                }
                else
                {
                    sphereVelocity.Y = 0;
                }
                randChance = rand.Next(VELOCITY_DIRECTIONS);
                if (randChance == 0)
                {
                    sphereVelocity.X = -1;
                }
                else if (randChance == 1)
                {
                    sphereVelocity.X = 1;
                }
                else
                {
                    sphereVelocity.X = 0;
                }

                if (sphereVelocity.X != 0 && sphereVelocity.Y != 0)     //check to see that both X and Y velocities are not equal to zero
                {
                    ballStopped = false;
                }
            }
            
        }

        public void fixWallCollsion()       //Checks to see if ball is on edge of screen and changes velocity so it bounces
        {
            if(sphereLocation.X < 0)
            {
                sphereVelocity.X = 1;
            }
            if(sphereLocation.Y < 0)
            {
                sphereVelocity.Y = 1;
            }
            int adjWidth = widthHeight.X - SPHERE_SIZE;
            int adjHeight = widthHeight.Y - SPHERE_SIZE;
            if(sphereLocation.X > adjWidth)
            {
                sphereVelocity.X = -1;
            }
            if(sphereLocation.Y > adjHeight)
            {
                sphereVelocity.Y = -1;
            }
        }
    }
}
