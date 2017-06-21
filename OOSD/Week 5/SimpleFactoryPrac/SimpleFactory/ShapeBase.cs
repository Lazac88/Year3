using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class ShapeBase
    {
        public int xLoc { set; get; }
        public int yLoc { set; get; }
        protected int size; // the sideLength of the containing square for all shapes
        protected Color shapeColour;
        protected Brush shapeBrush;
        protected Color backgroundColour;
        protected Brush backgroundBrush;

        public ShapeBase(Color bg, int startSize)
        {
            backgroundColour = bg;
            backgroundBrush = new SolidBrush(backgroundColour);
            size = startSize;
        }

        public abstract void Draw(Graphics canvas);

        public void Erase(Graphics canvas)
        {
            canvas.FillRectangle(backgroundBrush, xLoc, yLoc, size, size);
        }

    }
}
