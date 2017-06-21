using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureBuilder
{
    public interface ICreature
    {
        Head getHead();
        Body getBody();
        Feet getFeet();
    }
}
