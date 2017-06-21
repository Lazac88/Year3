using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipRefueling
{
    public class PetrolBot
    {
        private const int BOT_SIZE = 15;

        private Point homeLocation;
        private Point currentLocation;
        private Color botColour;
        private GraphicDisplay graphicDisplay;
        private Ship myShip;

        public PetrolBot(Point homeLocation, Color botColour, GraphicDisplay graphicDisplay, Ship myShip)
        {
            this.homeLocation = homeLocation;
            currentLocation = homeLocation;
            this.botColour = botColour;
            this.graphicDisplay = graphicDisplay;
            this.myShip = myShip;

            Ship.RefuelEventHandler refillHandler = new Ship.RefuelEventHandler(ShipNeedsRefuelEvent);
            myShip.RefuelEvent += refillHandler;

            EventHandler fillUpHandler = new EventHandler(ShipIsFullEvent);
            myShip.FullEvent += fillUpHandler;
        }

        public void Run()
        {
            graphicDisplay.drawPetrolBot(currentLocation, BOT_SIZE, botColour);
        }

        public void ShipNeedsRefuelEvent(object ship, PetrolEventArgs pe)
        {
            Point shipLoc = pe.ShipLoc;
            currentLocation = shipLoc;
        }

        public void ShipIsFullEvent(object ship, EventArgs e)
        {
            currentLocation = homeLocation;
        }
    }
}
