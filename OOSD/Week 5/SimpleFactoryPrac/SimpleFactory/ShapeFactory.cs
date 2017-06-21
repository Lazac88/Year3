using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class ShapeFactory
    {
        private const int NUM_SHAPES = 4;
        private Color backgroundColour;
        private int shapeDimension;
        private Random rand;

        public ShapeFactory(Color backgroundColour, int shapeDimension, Random rand)
        {
            this.backgroundColour = backgroundColour;
            this.shapeDimension = shapeDimension;
            this.rand = rand;
        }

        public ShapeBase getRandomShape()
        {
            ShapeBase newShapeInstance = null;
            int shapeChoice = rand.Next(NUM_SHAPES);

            switch (shapeChoice)
            {
                case 0:
                    newShapeInstance = new Square(backgroundColour, shapeDimension);
                    break;
                case 1:
                    newShapeInstance = new Circle(backgroundColour, shapeDimension);
                    break;
                case 2:
                    newShapeInstance = new Triangle(backgroundColour, shapeDimension);
                    break;
                case 3:
                    newShapeInstance = new Oval(backgroundColour, shapeDimension);
                    break;
            }
            return newShapeInstance;
        }
    }
}
