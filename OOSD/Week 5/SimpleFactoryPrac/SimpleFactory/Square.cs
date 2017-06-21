using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Square: ShapeBase
    {
        public Square(Color bg, int startSize): base(bg,startSize)
        {
            shapeColour = Color.Red;
            shapeBrush = new SolidBrush(shapeColour);
        }

        public override void Draw(Graphics canvas)
        {
            canvas.FillRectangle(shapeBrush, xLoc, yLoc, size, size);
        }
    }
}
