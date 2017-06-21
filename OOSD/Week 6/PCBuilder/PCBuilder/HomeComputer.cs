using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public class HomeComputer : Computer
    {
        public HomeComputer(ListBox displayBox)
            : base (displayBox)
        {
            computerFactory = new HomeComputerFactory();
        }
    }
}
