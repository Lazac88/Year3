using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class WitchFactory : ICreature
    {
        public Head getHead()
        {
            Head head = new WitchHead();
            return head;
        }

        public Body getBody()
        {
            Body body = new WitchBody();
            return body;
        }

        public Feet getFeet()
        {
            Feet feet = new WitchFeet();
            return feet;
        }
    }
}
