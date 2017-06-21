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

namespace Metronome
{

    public partial class Form1 : Form
    {
        private Metronome mainMetronome;
        private Beeper mainBeeper;
        private Counter mainCounter;
        private TimeDisplay mainTimeDisplay;


        private Thread metro;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainMetronome = new Metronome(1000, this);
            mainBeeper = new Beeper(mainMetronome, "blip1.wav");
            mainCounter = new Counter(mainMetronome, numericUpDown1);
            mainTimeDisplay = new TimeDisplay(mainMetronome, listBox1);

            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int currInterval = Convert.ToInt16(textBox1.Text);
            mainMetronome.Interval = currInterval;
            metro = new Thread(mainMetronome.start);
            metro.Start();
            //mainMetronome.start();
        }

        public void clearBuffer()
        {
            Application.DoEvents();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Code needed here to stop the metronome
            metro.Abort();
            numericUpDown1.Value = 0;
            listBox1.Items.Clear();
        }
    } // end Form
} // end namespace


//Note Invoke
