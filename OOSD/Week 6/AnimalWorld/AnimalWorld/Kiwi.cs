using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Kiwi : Animal
    {
        public Kiwi()
        {
            name = "Kiwi";
            family = "Omnivore";
            food = "Worms";
            image = new Bitmap("kiwi.jpg");
        }
    }
}
