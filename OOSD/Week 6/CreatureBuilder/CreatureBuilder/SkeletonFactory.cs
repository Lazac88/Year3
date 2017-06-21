using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class SkeletonFactory : ICreature
    {
        public Head getHead()
        {
            Head head = new SkeletonHead();
            return head;
        }

        public Body getBody()
        {
            Body body = new SkeletonBody();
            return body;
        }

        public Feet getFeet()
        {
            Feet feet = new SkeletonFeet();
            return feet;
        }
    }
}
