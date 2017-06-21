using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class MonsterBody : Body
    {
        public MonsterBody()
        {
            name = "Monster Body";
            image = new Bitmap("Frankenstein_1.png");
        }
    }
}
