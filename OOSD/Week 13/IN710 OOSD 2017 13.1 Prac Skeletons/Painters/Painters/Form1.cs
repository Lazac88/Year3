using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painters
{
    public partial class Form1 : Form
    {
        Graphics mainCanvas;
        Painter redPainter;
        Painter bluePainter;
        Painter greenPainter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainCanvas = CreateGraphics();
            redPainter = new Painter(255, 0, 0, mainCanvas, new Point(0, 0));
            bluePainter = new Painter(0, 0, 255, mainCanvas, new Point(50, 50));
            greenPainter = new Painter(0, 255, 0, mainCanvas, new Point(100, 100));
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            Refresh();
            redPainter.FillCanvas();
            bluePainter.FillCanvas();
            greenPainter.FillCanvas();
        }

        private void btnMultiThread_Click(object sender, EventArgs e)
        {
            Refresh();

            Thread redThread = new Thread(redPainter.FillCanvas);
            Thread blueThread = new Thread(bluePainter.FillCanvas);
            Thread greenThread = new Thread(greenPainter.FillCanvas);

            redThread.Start();
            blueThread.Start();
            greenThread.Start();
        }
    }
}

//=================================Question 2 Answers=============================//
/* B: The canvas is part way through drawing it's square when it loses the cpu, and the next thread attempts to grab the same canvas object to draw again
 * D: There is no way to guarentee the order of the threads. It depends who gets allocated cpu time first
 * /
