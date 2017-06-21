using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class MonsterFeet : Feet
    {
        public MonsterFeet()
        {
            name = "Frankenstein Feet";
            image = new Bitmap("Frankenstein_2.png");
        }
    }
}
