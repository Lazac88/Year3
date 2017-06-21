using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class GameComputerFactory : IComputerFactory
    {
        public Ram getRam()
        {
            Ram newRam = new GameRam();
            return newRam;

        }

        public CPU getCPU()
        {
            CPU newCPU = new GameCPU();
            return newCPU;
        }

        public GCard getGCard()
        {
            GCard newGCard = new GameGCard();
            return newGCard;
        }
        public Storage getStorage()
        {
            Storage newStorage = new GameStorage();
            return newStorage;
        }
    }
}
