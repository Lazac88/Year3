using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Strategy_Design
{
    interface IPrint
    {
        void DisplayAnimals(List<Critter> myList);
    }
}
