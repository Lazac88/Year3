using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painters
{
    class Painter
    {
        int r;
        int g;
        int b;

        Point startLocation;

        Brush paintBrush;
        Graphics canvas;

        public Painter(int r, int g, int b, Graphics canvas, Point startLocation)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            paintBrush = new SolidBrush(Color.FromArgb(r, g, b));
            this.canvas = canvas;
            this.startLocation = startLocation;
        }

        public void FillCanvas()
        {
            for (int i = 0; i < 500; i++)
                lock(canvas)
                {
                    canvas.FillRectangle(paintBrush, startLocation.X, startLocation.Y, i + 10, i + 10);

                }
        }
    }
}
