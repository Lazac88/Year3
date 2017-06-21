using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class American : Animal
    {
        public American()
        {
            name = "American";
            family = "Omnivore";
            food = "McDonalds";
            image = new Bitmap("american.jpg");
        }
    }
}
