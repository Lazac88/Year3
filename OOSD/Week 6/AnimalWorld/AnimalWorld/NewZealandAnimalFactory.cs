using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class NewZealandAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Kiwi();
                    break;
                case 1:
                    newAnimal = new Tuatara();
                    break;
                case 2:
                    newAnimal = new Moa();
                    break;
                case 3:
                    newAnimal = new Kea();
                    break;
            }
            return newAnimal;
        }
    }
}
