using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Moa : Animal
    {
        public Moa()
        {
            name = "Moa";
            family = "Omnivore";
            food = "Mammal Eggs";
            image = new Bitmap("moa.jpg");
        }
    }
}
