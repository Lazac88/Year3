using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFactory
{
    public partial class Form1 : Form
    {
        ShapeManager manager;
        int shapesToDisplay;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics mainCanvas = CreateGraphics();
            Random rGen = new Random();
            shapesToDisplay = Constants.SHAPES_TO_DISPLAY;
            manager = new ShapeManager(rGen, BackColor, mainCanvas, Width, Height, shapesToDisplay);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Manually resent display here, to avoid waiting for the timer's first tick.
            manager.FillListRandom();
            manager.DrawAllShapes();
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            manager.Cycle();
        }
    }
}
