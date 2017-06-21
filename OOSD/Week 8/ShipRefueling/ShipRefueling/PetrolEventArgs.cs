using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipRefueling
{
    public class PetrolEventArgs : EventArgs
    {
        public Point ShipLoc { get; set; }

        public PetrolEventArgs(Point shipLoc)
        {
            this.ShipLoc = shipLoc;
        }
    }
}
