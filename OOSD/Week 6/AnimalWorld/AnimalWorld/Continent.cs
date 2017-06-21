using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    //Base Class
    public abstract class Continent
    {
        public const int ANIMAL_SIM_COUNT = 4;

        protected ListBox displayBox;
        protected Random rand;
        protected int nAnimalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        public Continent(ListBox displayBox, Random rand, int nAnimalTypes, Graphics canvas)
        {
            this.displayBox = displayBox;
            this.rand = rand;
            this.nAnimalTypes = nAnimalTypes;
            this.canvas = canvas;
        }

        //A common method that all Continent descendants use
        //Uses the factory to create concrete animal instances, then runs the simulation
        public void runSimulation()
        {
            Animal currentAnimal;
            displayBox.Items.Clear();

            for (int i = 0; i < ANIMAL_SIM_COUNT; i++)
            {
                //Randomly Select an Animal Type
                int animalChoice = rand.Next(nAnimalTypes);

                //Use the factory
                currentAnimal = animalFactory.createAnimal(animalChoice);

                //Simulate the animal
                displayBox.Items.Add(currentAnimal.ToString());
                canvas.DrawImage(currentAnimal.Image, 20, 20 + (i * 120), 120, 120);
            }
        }
    }
}
