using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class WitchFeet : Feet
    {
        public WitchFeet()
        {
            name = "Witch Feet";
            image = new Bitmap("Witch_2.png");
        }
    }
}
