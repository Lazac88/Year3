using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Kea : Animal
    {
        public Kea()
        {
            name = "Kea";
            family = "Omnivore";
            food = "Insects";
            image = new Bitmap("kea.jpg");
        }
    }
}
