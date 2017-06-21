using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateInClass
{
    public partial class Form1 : Form
    {
        public delegate void Updater();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

        public void SlowMethod(Updater updater)
        {
            for(int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(100);
                updater();
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Updater updater = null;
            if(rBtnSpin.Checked)
            {
                updater = new Updater(UpdateSpinBox);
            }
            else if(rBtnProgress.Checked)
            {
                updater = new Updater(UpdateProgressbar);
            }
            else
            {
                updater = new Updater(UpdateTrackbar);
            }

            SlowMethod(updater);
        }
    }
}
