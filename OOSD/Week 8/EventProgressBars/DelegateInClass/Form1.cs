using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarEvents
{
    public partial class Form1 : Form
    {
        public delegate void Updater();

        public Form1()
        {
            InitializeComponent();
        }

        private ProgressBarSubject subject;
        private SpinBoxObserver sbo;
        private ProgressBarObserver pbo;
        private TrackBarObserver tbo;

        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new ProgressBarSubject();
            sbo = new SpinBoxObserver(subject, numericUpDown1);
            pbo = new ProgressBarObserver(subject, progressBar1);
            tbo = new TrackBarObserver(subject, trackBar1);
        }        

        public void SlowMethod()
        {
            for(int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(100);
                subject.OnButtonClick();
                //updater();
            }            
        }

        public void ClearProgressBars()
        {
            subject.OnClearEvent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ClearProgressBars();
            SlowMethod();



            //Updater updater = null;
            //if(rBtnSpin.Checked)
            //{
            //    updater = new Updater(UpdateSpinBox);
            //}
            //else if(rBtnProgress.Checked)
            //{
            //    updater = new Updater(UpdateProgressbar);
            //}
            //else
            //{
            //    updater = new Updater(UpdateTrackbar);
            //}

            //SlowMethod(updater);
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------//
        //Not Required
        public void UpdateSpinBox()
        {
            numericUpDown1.Value++;
            Application.DoEvents();
        }

        public void UpdateProgressbar()
        {
            progressBar1.Increment(1);
        }

        public void UpdateTrackbar()
        {
            trackBar1.Value++;
        }
    }
}
