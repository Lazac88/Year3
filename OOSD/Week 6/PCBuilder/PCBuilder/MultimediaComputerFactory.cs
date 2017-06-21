using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class MultimediaComputerFactory : IComputerFactory
    {
        public Ram getRam()
        {
            Ram newRam = new MultimediaRam();
            return newRam;

        }

        public CPU getCPU()
        {
            CPU newCPU = new MultimediaCPU();
            return newCPU;
        }

        public GCard getGCard()
        {
            GCard newGCard = new MultimediaGCard();
            return newGCard;
        }

        public Storage getStorage()
        {
            Storage newStorage = new MultimediaStorage();
            return newStorage;
        }
    }
}
