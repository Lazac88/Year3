using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Platypus : Animal
    {
        public Platypus()
        {
            name = "Platypus";
            family = "Omnivore";
            food = "Fish";
            image = new Bitmap("platypus.jpg");
        }
    }
}
