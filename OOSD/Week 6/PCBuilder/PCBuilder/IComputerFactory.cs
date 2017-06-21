using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public interface IComputerFactory
    {
        Ram getRam();
        CPU getCPU();
        GCard getGCard();
        Storage getStorage();
    }
}
