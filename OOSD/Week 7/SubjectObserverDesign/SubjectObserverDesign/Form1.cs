using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubjectObserverDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SubjectMonitorRPM myMonitor;
        RPMObserver myRPM;
        CalorieObserver myCal;
        DistanceObserver myDistance;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            myMonitor = new SubjectMonitorRPM();
            myRPM = new RPMObserver(lblRPM, myMonitor);
            myCal = new CalorieObserver(lblCalories, myMonitor);
            myDistance = new DistanceObserver(lblDistance, myMonitor);
        }

        private void btnRPM_Click(object sender, EventArgs e)
        {
            int myRPM = Convert.ToInt32(txtBoxRpmInput.Text);
            myMonitor.cycleRPM = myRPM;
            myMonitor.alertObservers();
        }

    }
}
