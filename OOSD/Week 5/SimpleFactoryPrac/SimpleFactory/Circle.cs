using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Circle: ShapeBase
    {
        public Circle(Color bg, int startSize): base(bg,startSize)
        {
            shapeColour = Color.Blue;
            shapeBrush = new SolidBrush(shapeColour);
        }

        public override void Draw(Graphics canvas)
        {
            canvas.FillEllipse(shapeBrush, xLoc, yLoc, size, size);
        }
    }
}
