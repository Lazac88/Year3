using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Triangle: ShapeBase
    {
        public Triangle(Color bg, int startSize): base(bg,startSize)
        {
            shapeColour = Color.Green;
            shapeBrush = new SolidBrush(shapeColour);
        }

        public override void Draw(Graphics canvas)
        {
            Point p1 = new Point(xLoc, yLoc);
            Point p2 = new Point(xLoc + size, yLoc);
            Point p3 = new Point(xLoc + size, yLoc + size);
            Point[] vertices = new Point[] { p1, p2, p3 };
            canvas.FillPolygon(shapeBrush, vertices);
        }
    }
}
