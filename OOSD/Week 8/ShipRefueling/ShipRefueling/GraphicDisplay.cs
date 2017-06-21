using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipRefueling
{
    public class GraphicDisplay
    {
        private Graphics mainGraphics;
        private Bitmap offScreenBitmap;
        private Graphics offScreenCanvas;
        private Panel displayPanel;

        private Point panelSize;

        private SolidBrush blueBrush;
        private SolidBrush blackBrush;

        public GraphicDisplay(Panel displayPanel, Point panelSize)
        {
            this.panelSize = panelSize;
            this.displayPanel = displayPanel;

            blueBrush = new SolidBrush(Color.Blue);
            blackBrush = new SolidBrush(Color.Black);

            //Double Buffering
            offScreenBitmap = new Bitmap(panelSize.X, panelSize.Y);
            offScreenCanvas = Graphics.FromImage(offScreenBitmap);
            mainGraphics = displayPanel.CreateGraphics();
        }
        public void clearPanel()
        {
            offScreenCanvas.FillRectangle(blueBrush, 0, 0, panelSize.X, panelSize.Y);
        }

        public void drawShip(Point shipLocation, int shipSize, Color shipColour)
        {
            SolidBrush shipBrush = new SolidBrush(shipColour);
            int xLoc = shipLocation.X; 
            int yLoc = shipLocation.Y;
            offScreenCanvas.FillRectangle(shipBrush, xLoc, yLoc, shipSize, shipSize);
        }
        public void drawPetrolBot(Point botLocation, int botSize, Color botColour)
        {
            SolidBrush botBrush = new SolidBrush(botColour);
            int xLoc = botLocation.X;
            int yLoc = botLocation.Y;
            offScreenCanvas.FillEllipse(botBrush, xLoc, yLoc, botSize, botSize);            
        }

        public void drawToCanvas()
        {
            mainGraphics.DrawImage(offScreenBitmap, 0, 0);
        }

        public void drawBase()
        {
            offScreenCanvas.FillRectangle(blackBrush, 0, 740, panelSize.X, 80);
        }
    }
}
