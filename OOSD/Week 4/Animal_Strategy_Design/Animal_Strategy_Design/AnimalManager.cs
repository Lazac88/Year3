using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Strategy_Design
{   

    class AnimalManager
    {
        public IPrint myDisplay { get; set; }

        public AnimalManager()
        {

        }
    }
}
