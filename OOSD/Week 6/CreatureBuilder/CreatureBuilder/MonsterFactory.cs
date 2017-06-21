using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class MonsterFactory : ICreature
    {
        public Head getHead()
        {
            Head head = new MonsterHead();
            return head;
        }

        public Body getBody()
        {
            Body body = new MonsterBody();
            return body;
        }

        public Feet getFeet()
        {
            Feet feet = new MonsterFeet();
            return feet;
        }
    }
}
