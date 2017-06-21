using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OT_Visual_Project
{
    class GraphicDisplaySphere : IGraphicDisplay
    {
        private const int IMAGE_SIZE = 50;     //??Should this be passed into the graphics display
        private const int NUMBER_IMAGES = 2;    //Will need to be changed depending on how many images there are

        private Graphics mainGraphics;
        private Bitmap offScreenBitmap;
        private Graphics offScreenCanvas;
        private Panel displayPanel;

        private List<Image> imageList;
        
        private Image imageCurrent;

        private SolidBrush blackBrush;

        private int colourCount;

        //Needed to completely clear panel
        private Point panelSize;

        public GraphicDisplaySphere(Panel displayPanel, Point panelSize)
        {
            this.panelSize = panelSize;
            this.displayPanel = displayPanel;

            blackBrush = new SolidBrush(Color.Black);

            //Set up images
            imageList = new List<Image>();
            setupImages();
            imageCurrent = imageList[0];

            
            colourCount = 0;

            //Double Buffering
            offScreenBitmap = new Bitmap(panelSize.X, panelSize.Y);
            offScreenCanvas = Graphics.FromImage(offScreenBitmap);
            mainGraphics = displayPanel.CreateGraphics();
        }

        public void setupImages()
        {
            //Can add more images here if required
            Image imageGreen = Properties.Resources.greenBall;
            Image imagePurple = Properties.Resources.purpleSphere;

            imageList.Add(imageGreen);
            imageList.Add(imagePurple);
        }

        public void changeStimulusColour()        //Changes sphere.
        {
            int swapImage = colourCount % NUMBER_IMAGES;
            imageCurrent = imageList[swapImage];
            colourCount++;
        }

        public void clearPanel()
        {
            offScreenCanvas.FillRectangle(blackBrush, 0, 0, panelSize.X, panelSize.Y);
        }
        
        public void drawStimulus(Point stimLocation)
        {
            int xLoc = stimLocation.X; //* IMAGE_SIZE;
            int yLoc = stimLocation.Y; //*IMAGE_SIZE;
            offScreenCanvas.DrawImage(imageCurrent, xLoc, yLoc, IMAGE_SIZE, IMAGE_SIZE);
            mainGraphics.DrawImage(offScreenBitmap, 0, 0);
        }
    }
}
