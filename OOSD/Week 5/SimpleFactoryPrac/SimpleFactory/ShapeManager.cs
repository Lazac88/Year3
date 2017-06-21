using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class ShapeManager
    {

        List<ShapeBase> shapeList;
        Random rGen;
        Color backgroundColour;
        ShapeFactory shapeFactory;
        Graphics canvas;
        int screenWidth;
        int screenHeight;
        int shapeDimension;
        int shapeVarieties;

        // user can potentially want to change this at runtime
        public int ShapesToDisplay {get; set;}

        public ShapeManager(Random rGen, Color backgroundColour, Graphics canvas, int w, int h, int nShapes)
        {
            shapeList = new List<ShapeBase>();
            this.rGen = rGen;
            this.backgroundColour = backgroundColour;
            this.canvas = canvas;
            screenHeight = h;
            screenWidth = w;
            ShapesToDisplay = nShapes;

            shapeDimension = Constants.SHAPE_DIMENSION;
            shapeVarieties = Constants.SHAPE_VARIETIES;
            shapeFactory = new ShapeFactory(backgroundColour, shapeDimension, rGen);

            
        }

        public void Cycle()
        {
            EraseAllShapes();
            FillListRandom();
            DrawAllShapes();
        }

        // Uses the data member ShapesToDisplay
        // Might be more flexible to let it accept that value as an argument.
        public void FillListRandom()
        {
            ShapeBase newShapeInstance = null;
            shapeList.Clear();

            for (int i = 0; i < ShapesToDisplay; i++)
            {                   
                newShapeInstance = shapeFactory.getRandomShape();
                newShapeInstance.xLoc = rGen.Next(0, screenWidth - shapeDimension);
                newShapeInstance.yLoc = rGen.Next(0, screenHeight - shapeDimension);
                shapeList.Add(newShapeInstance);
            }

        } // end fillListRandom();

        public void DrawAllShapes()
        {
            foreach (ShapeBase s in shapeList)
                s.Draw(canvas);
        }

        public void EraseAllShapes()
        {
            foreach (ShapeBase s in shapeList)
                s.Erase(canvas);
        }

     } // end ShapeManager 
}
