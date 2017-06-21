using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class AustralianAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Koala();
                    break;
                case 1:
                    newAnimal = new Kangaroo();
                    break;
                case 2:
                    newAnimal = new Crocodile();
                    break;
                case 3:
                    newAnimal = new Platypus();
                    break;
            }
            return newAnimal;
        }
    }
}
