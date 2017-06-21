using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class HomeComputerFactory : IComputerFactory
    {
        public Ram getRam()
        {
            Ram newRam = new HomeRam();
            return newRam;

        }
        public CPU getCPU()
        {
            CPU newCPU = new HomeCPU();
            return newCPU;
        }
        public GCard getGCard()
        {
            GCard newGCard = new HomeGCard();
            return newGCard;
        }

        public Storage getStorage()
        {
            Storage newStorage = new HomeStorage();
            return newStorage;
        }
    }
}
