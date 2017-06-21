using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Oval: ShapeBase
    {
        public Oval(Color bg, int startSize): base(bg,startSize)
        {
            shapeColour = Color.MediumPurple;
            shapeBrush = new SolidBrush(shapeColour);
        }

        public override void Draw(Graphics canvas)
        {
            double widthD = size * 0.5;
            int widthI = Convert.ToInt32(widthD);
            canvas.FillEllipse(shapeBrush, xLoc, yLoc, widthI, size);
        }
    }
}
