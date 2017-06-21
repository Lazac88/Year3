using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class MonsterHead : Head
    {
        public MonsterHead()
        {
            name = "Monster Head";
            image = new Bitmap("Frankenstein_0.png");
        }
    }
}
