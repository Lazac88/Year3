using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OT_Visual_Project
{
    class GraphicDisplay :IGraphicDisplay
    {
        private const int SQUARE_SIZE = 50;     //??Should this be passed into the graphics display

        private Graphics mainGraphics;
        private Bitmap offScreenBitmap;
        private Graphics offScreenCanvas;
        private Panel displayPanel;
        

        //Collection of different colours to use
        private SolidBrush whiteBrush;
        private SolidBrush greenBrush;
        private SolidBrush blackBrush;
        private SolidBrush yellowBrush;

        //Needed to completely clear panel
        private Point panelSize;

        public GraphicDisplay(Point panelSize, Panel displayPanel)
        {
            whiteBrush = new SolidBrush(Color.White);
            greenBrush = new SolidBrush(Color.LightGreen);
            blackBrush = new SolidBrush(Color.Black);
            yellowBrush = new SolidBrush(Color.Yellow);
            this.panelSize = panelSize;
            this.displayPanel = displayPanel;

            //Double Buffering
            offScreenBitmap = new Bitmap(panelSize.X, panelSize.Y);
            offScreenCanvas = Graphics.FromImage(offScreenBitmap);
            mainGraphics = displayPanel.CreateGraphics();
        }

        public void drawStimulus(Point stimLocation)
        {
            int pixelLocX = stimLocation.X * SQUARE_SIZE;
            int pixelLocY = stimLocation.Y * SQUARE_SIZE;
            offScreenCanvas.FillRectangle(whiteBrush, pixelLocX, pixelLocY, SQUARE_SIZE, SQUARE_SIZE);
            mainGraphics.DrawImage(offScreenBitmap, 0, 0);

        }

        public void clearPanel()
        {
            offScreenCanvas.FillRectangle(blackBrush, 0, 0, panelSize.X, panelSize.Y);
            mainGraphics.DrawImage(offScreenBitmap, 0, 0);
        }

        public void changeStimulusColour(Point stimLocation)    //Change the stimulus colour when the patient clicks correctly
        {
            int pixelLocX = stimLocation.X * SQUARE_SIZE;
            int pixelLocY = stimLocation.Y * SQUARE_SIZE;
            mainGraphics.FillRectangle(greenBrush, pixelLocX, pixelLocY, SQUARE_SIZE, SQUARE_SIZE);
        }

        public void drawAllStimulus(List<Stimulus> myList)      //Additional feature for visual feedback on patients visual spots and blind spots
        {
            foreach(Stimulus s in myList)
            {
                int pixelLocX = s.getStimulusLoc().X * SQUARE_SIZE;
                int pixelLocY = s.getStimulusLoc().Y * SQUARE_SIZE;
                mainGraphics.FillRectangle(yellowBrush, pixelLocX, pixelLocY, SQUARE_SIZE, SQUARE_SIZE);
            }
        }

    }
}
