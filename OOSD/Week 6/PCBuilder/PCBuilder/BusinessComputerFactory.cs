using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class BusinessComputerFactory : IComputerFactory
    {
        public Ram getRam()
        {
            Ram newRam = new BusinessRam();
            return newRam;

        }

        public CPU getCPU()
        {
            CPU newCPU = new BusinessCPU();
            return newCPU;
        }

        public GCard getGCard()
        {
            GCard newGCard = new BusinessGCard();
            return newGCard;
        }
        public Storage getStorage()
        {
            Storage newStorage = new BusinessStorage();
            return newStorage;
        }
    }
}
