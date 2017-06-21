using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public class NewZealand : Continent
    {
        public NewZealand(ListBox displayBox, Random rand, int nAnimalTypes, Graphics canvas) 
            : base(displayBox, rand, nAnimalTypes, canvas)
        {
            animalFactory = new NewZealandAnimalFactory();
        }
    }
}
