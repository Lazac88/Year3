using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public class CreatureFactoryFactory
    {
        public ICreature getMonsterFactory()
        {
            ICreature myFactory = new MonsterFactory();
            return myFactory;
        }

        public ICreature getSkeletonFactory()
        {
            ICreature myFactory = new SkeletonFactory();
            return myFactory;
        }

        public ICreature getWitchFactory()
        {
            ICreature myFactory = new WitchFactory();
            return myFactory;
        }
    }
}
