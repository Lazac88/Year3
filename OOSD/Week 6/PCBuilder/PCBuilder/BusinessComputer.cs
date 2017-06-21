using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public class BusinessComputer : Computer
    {
        public BusinessComputer(ListBox displayBox)
            : base (displayBox)
        {
            computerFactory = new BusinessComputerFactory();
        }
    }    
}
