using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Strategy_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClockManager clockManager;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            clockManager = new ClockManager(lblDigitalClock);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockManager.runClock();
        }

        private void radioButtonDigital_MouseDown(object sender, MouseEventArgs e)
        {
            clockManager.hideClock();
            clockManager.clockType = new DigitalClock(lblDigitalClock);
            clockManager.showClock();
        }

        private void radioButtonAnalouge_MouseClick(object sender, MouseEventArgs e)
        {
            clockManager.hideClock();
            clockManager.clockType = new AnalogueClock(analogClock);
            clockManager.showClock();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            clockManager.startClock();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            clockManager.stopClock();
        }
    }
}
