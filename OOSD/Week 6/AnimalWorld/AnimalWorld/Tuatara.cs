using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Tuatara : Animal
    {
        public Tuatara()
        {
            name = "Tuatara";
            family = "Omnivore";
            food = "Insects";
            image = new Bitmap("tuatara.jpg");
        }
    }
}
